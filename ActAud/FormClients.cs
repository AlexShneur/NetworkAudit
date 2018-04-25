using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using GongSolutions.Shell;
using System.Net;
using GongSolutions.Shell.Interop;
using System.Collections;
using System.Diagnostics;
using System.Net.Sockets;

namespace ActAud
{
    public partial class FormClients : Form
    {
        //максимальный размер получаемого сообщения, буфера и пула для WCF 
        private readonly long MAX_SIZE_WCF = (long)(((ulong)3 * 1024 * 1024 * 1024) / 2);

        private BackgroundWorker addServersWorker = new BackgroundWorker();

        private List<MonServer> serverObjects = new List<MonServer>();

        public FormClients()
        {
            InitializeComponent();
        }
     
        private void FormClients_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void AddMonServers(DoWorkEventArgs eventArgs)
        {
            ShellNetworkComputers comps = new ShellNetworkComputers();
            IEnumerator<string> names = comps.GetEnumerator();
            while (names.MoveNext())
            {
                try
                {
                    string name = names.Current.Remove(0, 2);
                    IPAddress[] addresses = Dns.GetHostAddresses(name).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToArray();
                    for (int i = 0; i < addresses.Length; i++)
                    {
                        IPAddress serverIP = addresses[i];
                        if (AddMonServer(serverIP));
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.Message);
                }
                //если поступил запрос на останов поиска серверов
                if (addServersWorker.CancellationPending)
                {
                    eventArgs.Cancel = true;
                    return;
                }
            }
        }

        private bool AddMonServer(IPAddress serverIP)
        {
            try
            {
                Uri address = new Uri("net.tcp://" + serverIP + ":41993/IMonService/");
                NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);    

                binding.MaxReceivedMessageSize = MAX_SIZE_WCF;
                binding.MaxBufferSize = Convert.ToInt32(MAX_SIZE_WCF);
                binding.MaxBufferPoolSize = MAX_SIZE_WCF;

                EndpointAddress monEndpoint = new EndpointAddress(address);
                ChannelFactory<IMonService> monFactory = new ChannelFactory<IMonService>(binding, monEndpoint);
                IMonService monServer = monFactory.CreateChannel();
                if (monServer.TestConnection())
                {
                    MonServer server = new MonServer(monServer);
                    serverObjects.Add(server);
                    AddToListBoxClients(serverIP.ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AddToListBoxClients(object oo)
        {
            Invoke(new MethodInvoker(
                           delegate { lsbClients.Items.Add(oo); }
                           ));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //затем запускаем поток поиска и добавления новых серверов
            try
            {
                addServersWorker.DoWork += addServersWorker_DoWork;
                //запускаем поток для добавления серверов в фоновом режиме
                addServersWorker.WorkerReportsProgress = true;
                addServersWorker.WorkerSupportsCancellation = true;
                addServersWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addServersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            AddMonServers(e);
        }


        //класс для поиска серверов
        sealed class ShellNetworkComputers : IEnumerable<string>
        {
            public IEnumerator<string> GetEnumerator()
            {
                ShellItem folder = new ShellItem((Environment.SpecialFolder)CSIDL.NETWORK);
                IEnumerator<ShellItem> e = folder.GetEnumerator(SHCONTF.FOLDERS);

                while (e.MoveNext())
                {
                    yield return e.Current.ParsingName;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        private void lsbClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            foreach (MonServer server in serverObjects)
            {
                string serverIP = "";
                for (int i=0; i<server.IPaddr.Length-1; i++)
                {
                    serverIP += server.IPaddr[i] + ".";
                }
                serverIP += server.IPaddr[server.IPaddr.Length - 1];
                if (serverIP.Equals(lsbClients.SelectedItem.ToString()))
                {
                    AuditForm auditLogForm = new AuditForm(server);
                    auditLogForm.Show();
                }
            }
        }
    }
}
