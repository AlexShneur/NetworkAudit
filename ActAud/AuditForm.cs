using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActAud
{
    public partial class AuditForm : Form
    {
        AuditLog AUDIL;
        MonServer server;

        // имя каталога для аудита файловой системы
        string dirname;
        FileSystemWatcher watcher;
        public AuditForm(MonServer _server)
        {
            InitializeComponent();
            server = _server;
        }

        private void btnRefreshLogLIst_Click(object sender, EventArgs e)
        {
            AUDIL.EventLogList(tvSystemEventsList);
        }

        private void btnViewCurrentLog_Click(object sender, EventArgs e)
        {
            AUDIL.EventLogSee(tvSystemEventsList, dataGridViewCurrentLog, gbCurrentLog);
        }

        private void btnViewCurrentLogWithFilter_Click(object sender, EventArgs e)
        {
            if (rbByID.Checked) AUDIL.EventLogSeeFilter(tvSystemEventsList, dataGridViewCurrentLog, tbID, 0);
            if (rbByMessageType.Checked) AUDIL.EventLogSeeFilter(tvSystemEventsList, dataGridViewCurrentLog, tbMessageType, 1);
            if (rbByDate.Checked) AUDIL.EventLogSeeFilter(tvSystemEventsList, dataGridViewCurrentLog, dateTimePickerFrom, dateTimePickerTo);
            if (rbByComputer.Checked) AUDIL.EventLogSeeFilter(tvSystemEventsList, dataGridViewCurrentLog, tbComputer, 3);
        }

        private void btnStartEventMonitoring_Click(object sender, EventArgs e)
        {
            /*rtbMonitoredEvents.Clear();
            // Регистрация событий. Системный журнал
            EventLog eventLog = server.GetEventLog("System");
            eventLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten1);
            eventLog.EnableRaisingEvents = true;
            // Регистрация событий. Журнал безопасности
            EventLog securitylog = server.GetEventLog("Security");
            securitylog.EntryWritten += new EntryWrittenEventHandler(OnEntrySecurityWritten);
            securitylog.EnableRaisingEvents = true;
            MessageBox.Show("Мониторинг событий успешно запущен.");
            lbStatus.Text = "запущен";*/
        }

        private void OnEntryWritten1(object sender, EntryWrittenEventArgs e)
        {
            if (e.Entry.EntryType == EventLogEntryType.Error || e.Entry.EntryType == EventLogEntryType.Information)
            {
                if ((e.Entry.EventID == 4) || (e.Entry.EventID == 472) || (e.Entry.EventID == 477) || (e.Entry.EventID == 517) ||
                           (e.Entry.EventID == 624) || (e.Entry.EventID == 535) || (e.Entry.EventID == 533) || (e.Entry.EventID == 529) ||
                           (e.Entry.EventID == 632) || (e.Entry.EventID == 539) || (e.Entry.EventID == 534) || (e.Entry.EventID == 531) ||
                           (e.Entry.EventID == 636) || (e.Entry.EventID == 660) || (e.Entry.EventID == 6806) || (e.Entry.EventID == 4645) ||
                           (e.Entry.EventID == 642) || (e.Entry.EventID == 675) || (e.Entry.EventID == 681) || (e.Entry.EventID == 4728) ||
                           (e.Entry.EventID == 644) || (e.Entry.EventID == 676) || (e.Entry.EventID == 1102) || (e.Entry.EventID == 4732) ||
                           (e.Entry.EventID == 4740) || (e.Entry.EventID == 4756) || (e.Entry.EventID == 4768) || (e.Entry.EventID == 4776) ||
                           (e.Entry.EventID == 4738) || (e.Entry.EventID == 4733) || (e.Entry.EventID == 630) || (e.Entry.EventID == 200) ||
                           (e.Entry.EventID == 4124) || (e.Entry.EventID == 4226) || (e.Entry.EventID == 7901) ||
                           (e.Entry.EventID == 12294) || (e.Entry.EventID == 9095) || (e.Entry.EventID == 9097) || (e.Entry.EventID == 7023) ||
                           (e.Entry.EventID == 6183) || (e.Entry.EventID == 55) || (e.Entry.EventID == 1066) || (e.Entry.EventID == 6008) ||
                           (e.Entry.EventID == 861) || e.Entry.EventID == 7035)
                {
                    //MessageBox.Show("Внимание! В системе произошло событие   "+  e.Entry.EventID+ ".  Просмотрите журнал событий для выяснения причин.", "Система активного аудита", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult result;
                    result = MessageBox.Show("Внимание!" + "\r\n" + "В системе произошло событие    " + e.Entry.EventID + "\r\n" + "Время     " +
                        e.Entry.TimeGenerated.ToString() + "\r\n" + "Сообщение:  " + e.Entry.Message + "\r\n" + "\r\n" + "  Просмотрите журнал событий для выяснения причин.", "Мониторинг событий ИБ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Обработка события записи в журнал безопасности
        protected void OnEntrySecurityWritten(object sender, EntryWrittenEventArgs e)
        {
            rtbMonitoredEvents.AppendText("Запись в журнал " + ((EventLog)sender).LogDisplayName + " Время " + e.Entry.TimeWritten + "Позиция " + e.Entry.Index + "\r\n");
        }

        private void AuditForm_Load(object sender, EventArgs e)
        {
            // Инициализация страницы системного аудита
            AUDIL = new AuditLog(server);
            AUDIL.EventLogList(tvSystemEventsList);
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            watcher.Changed -= OnChanged;
            watcher.Created -= OnCreated;
            watcher.Deleted -= OnDeleted;
            watcher.Renamed -= OnRenamed;
            MessageBox.Show("Мониторинг событий файловой системы успешно остановлен.");
            btnStartMonitoring.Enabled = true;
            btnStopMonitoring.Enabled = false;
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            watcher = server.GetFileSystemWatcher();
            watcher.Path = dirname;
            // Установка фильтров
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Список файлов, за которыми ведется наблюдение
            watcher.Filter = "*.*";
            // Добавление обработчиков событий
            if (clbActions.SelectedIndex == 4)
            {
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnCreated);
                watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);
            }
            else
            {
                if (clbActions.SelectedIndex == 0) watcher.Changed += new FileSystemEventHandler(OnChanged);
                if (clbActions.SelectedIndex == 1) watcher.Created += new FileSystemEventHandler(OnCreated);
                if (clbActions.SelectedIndex == 2) watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                if (clbActions.SelectedIndex == 3) watcher.Renamed += new RenamedEventHandler(OnRenamed);
            }
            watcher.EnableRaisingEvents = true;
            MessageBox.Show("Мониторинг событий файловой системы успешно запущен.");
            btnStartMonitoring.Enabled = false;
            btnStopMonitoring.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = server.GetFolderBrowserDIalog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dirname = fbd.SelectedPath;
                lbDirectoryName.Text = dirname;
                pnElements.Enabled = true;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Invoke(new Action(() =>
            {
                rtbInformation.AppendText(e.FullPath + "   " + e.ChangeType + "\r\n");
            }));
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            Invoke(new Action(() =>
            {
                rtbInformation.AppendText(e.FullPath + "   " + e.ChangeType + "\r\n");
            }));
        }

        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            Invoke(new Action(() =>
            {
                rtbInformation.AppendText(e.FullPath + "   " + e.ChangeType + "\r\n");
            }));
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                rtbInformation.AppendText(e.OldFullPath + " переименован в " + e.FullPath + "\r\n");
            }));
        }

        private void tmrAuditDevices_Tick(object sender, EventArgs e)
        {
            string devicesLog = server.CheckDevices();
            if (!string.IsNullOrEmpty(devicesLog))
            {
                lsbAuditDevices.Items.Add(devicesLog);
                lsbAuditDevices.SelectedIndex = lsbAuditDevices.Items.Count - 1;
            }
        }
    }
}
