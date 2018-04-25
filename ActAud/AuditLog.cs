using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActAud
{
    //------------------------------------------------------------------------------------
    // Просмотр журналов аудита
    //------------------------------------------------------------------------------------
    public class AuditLog
    {
        public TreeView logTreeView;
        public TreeNode InfoNode;
        public DataGridView logDataGridView, errorDataGridView;
        public TextBox logTextBox;
        public int logFilterNumber;
        public DateTimePicker logDateTimePicker1;
        public DateTimePicker logDateTimePicker2;
        public GroupBox groupBox;

        MonServer server;

        public AuditLog(MonServer _server)
        {
            server = _server;
        }

        //---------------------------------------------
        // Получение списка доступных журналов
        //---------------------------------------------
        public void EventLogList(TreeView aTreeView)
        {
            // Создание дерева журналов
            logTreeView = aTreeView;
            logTreeView.Nodes.Clear();
            InfoNode = new TreeNode();
            InfoNode.Text = "Список доступных журналов аудита";
            logTreeView.Nodes.Add(InfoNode);
            EventLog[] elogs = server.GetEventLogs();
            foreach (EventLog elog in elogs)
            {
                logTreeView.Nodes[0].Nodes.Add(elog.Log.ToString() + " (" + elog.LogDisplayName.ToString() + ")");
                elog.Close();
            }
            elogs = null;
        }
        //---------------------------------------------
        // Просмотр выбранного журнала
        //---------------------------------------------
        public void EventLogSee(TreeView aTreeView, DataGridView aDataGridView, GroupBox agroupBox)
        {
            logDataGridView = aDataGridView;
            logDataGridView.Rows.Clear();
            groupBox = agroupBox;
            string tmp = "";
            string logType = "";
            int k = 0;
            if (logTreeView.SelectedNode != null)
            {
                tmp = logTreeView.SelectedNode.Text;
                k = tmp.IndexOf(" (");
                if (k != 0) logType = tmp.Substring(0, k);
                //EventLog ev = server.GetEventLog(logType);
                //int LastLogToShow = ev.Entries.Count;

                EventLogEntryCollection logEntries = server.GetEventLogEntries(logType);
                int LastLogToShow = logEntries.Count;

                if (LastLogToShow <= 0)
                {
                    string message = "В журнале: " + logType + " отсутствуют записи";
                    string caption = "Просмотр журналов событий";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // чтение выбранного журнала
                    groupBox.Text = "Просмотр журнала " + logType;
                    int i = 0;
                    for (i = 0; i < LastLogToShow; i++)
                    {
                        //EventLogEntry CurrentEntry = ev.Entries[i];
                        EventLogEntry CurrentEntry = logEntries[i];
                        logDataGridView.Rows.Add(CurrentEntry.InstanceId, CurrentEntry.EntryType.ToString(), CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                    }
                }
                //ev.Close();
            }
            else MessageBox.Show("Ни один журнал не выбран", "Просмотр журналов событий", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //---------------------------------------------
        // Просмотр выбранного журнала с учетом фильтра
        //---------------------------------------------
        public void EventLogSeeFilter(TreeView aTreeView, DataGridView aDataGridView, TextBox aTextBox, int aFilterNumber)
        {
            // Передача переменных
            logTreeView = aTreeView;
            logDataGridView = aDataGridView;
            logTextBox = aTextBox;
            logFilterNumber = aFilterNumber;

            logDataGridView.Rows.Clear();
            string tmp = "";
            string logType = "";
            int k = 0;
            if (logTreeView.SelectedNode != null)
            {
                tmp = logTreeView.SelectedNode.Text;
                k = tmp.IndexOf(" (");
                if (k != 0) logType = tmp.Substring(0, k);
                //EventLog ev = server.GetEventLog(logType);
                //int LastLogToShow = ev.Entries.Count;
                EventLogEntryCollection logEntries = server.GetEventLogEntries(logType);
                int LastLogToShow = logEntries.Count;
                if (LastLogToShow <= 0)
                {
                    string message = "В журнале: " + logType + " отсутствуют записи";
                    string caption = "Просмотр журналов событий";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // чтение выбранного журнала
                    int i = 0;
                    int c = 0;
                    for (i = 0; i < LastLogToShow; i++)
                    {
                        //EventLogEntry CurrentEntry = ev.Entries[i];
                        EventLogEntry CurrentEntry = logEntries[i];
                        switch (logFilterNumber)
                        {
                            case 0:
                                {
                                    if (string.Equals(logTextBox.Text, CurrentEntry.InstanceId.ToString()))
                                        logDataGridView.Rows.Add(CurrentEntry.InstanceId, CurrentEntry.EntryType.ToString(), CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                                    break;
                                }
                            case 1:
                                if (string.Equals(logTextBox.Text, CurrentEntry.EntryType.ToString()))
                                    logDataGridView.Rows.Add(CurrentEntry.EventID, CurrentEntry.EntryType.ToString(), CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                                break;

                            case 3:
                                if (string.Equals(logTextBox.Text, CurrentEntry.MachineName.ToString()))
                                    logDataGridView.Rows.Add(CurrentEntry.EventID, CurrentEntry.EntryType.ToString(), CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                                break;

                        }

                    }
                }
                //ev.Close();
            }
            else MessageBox.Show("Ни один журнал не выбран", "Просмотр журналов событий", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------
        // Просмотр выбранного журнала с учетом фильтра
        //---------------------------------------------
        public void EventLogSeeFilter(TreeView aTreeView, DataGridView aDataGridView, DateTimePicker aDateTimePicker1, DateTimePicker aDateTimePicker2)
        {
            // Передача переменных
            logTreeView = aTreeView;
            logDataGridView = aDataGridView;
            logDateTimePicker1 = aDateTimePicker1;
            logDateTimePicker2 = aDateTimePicker2;
            logDataGridView.Rows.Clear();
            DateTimePicker tmpdateTimePicker;
            string tmp = "";
            string logType = "";
            int k = 0;
            if (logTreeView.SelectedNode != null)
            {
                tmp = logTreeView.SelectedNode.Text;
                k = tmp.IndexOf(" (");
                if (k != 0) logType = tmp.Substring(0, k);
                //EventLog ev = server.GetEventLog(logType);
                //int LastLogToShow = ev.Entries.Count;
                EventLogEntryCollection logEntries = server.GetEventLogEntries(logType);
                int LastLogToShow = logEntries.Count;
                if (LastLogToShow <= 0)
                {
                    string message = "В журнале: " + logType + " отсутствуют записи";
                    string caption = "Просмотр журналов событий";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // чтение выбранного журнала
                    int i = 0;
                    int c = 0;
                    for (i = 0; i < LastLogToShow; i++)
                    {
                        //EventLogEntry CurrentEntry = ev.Entries[i];
                        EventLogEntry CurrentEntry = logEntries[i];
                        if (logDateTimePicker1.Value > logDateTimePicker2.Value)
                        {
                            tmpdateTimePicker = logDateTimePicker1;
                            logDateTimePicker1 = logDateTimePicker2;
                            logDateTimePicker2 = tmpdateTimePicker;
                        }
                        if ((CurrentEntry.TimeGenerated.Date >= logDateTimePicker1.Value) && (CurrentEntry.TimeGenerated.Date <= logDateTimePicker2.Value))
                            logDataGridView.Rows.Add(CurrentEntry.InstanceId, CurrentEntry.EntryType.ToString(), CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                    }
                }
                //ev.Close();
            }
            else MessageBox.Show("Ни один журнал не выбран", "Просмотр журналов событий", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------
        // Очистка выбранного журнала
        //---------------------------------------------
        public void EventLogClear(TreeView aTreeView, DataGridView aDataGridView)
        {
            logDataGridView = aDataGridView;
            logDataGridView.Rows.Clear();
            string tmp = "";
            string logType = "";
            int k = 0;
            if (logTreeView.SelectedNode != null)
            {
                tmp = logTreeView.SelectedNode.Text;
                k = tmp.IndexOf(" (");
                if (k != 0) logType = tmp.Substring(0, k);
                //EventLog ev = server.GetEventLog(logType);
                //int LastLogToShow = ev.Entries.Count;
                EventLogEntryCollection logEntries = server.GetEventLogEntries(logType);
                int LastLogToShow = logEntries.Count;
                if (LastLogToShow <= 0)
                {
                    string message = "В журнале: " + logType + " записи уже отсутствуют";
                    string caption = "Очистка журналов событий";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //ev.Clear();
                    //ev.Close();
                }
            }
            else MessageBox.Show("Ни один журнал не выбран", "Очистка журналов событий", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ErrorLogSee(TreeView aTreeView, DataGridView aDataGridView, GroupBox agroupBox)
        {

            logDataGridView = aDataGridView;
            errorDataGridView = aDataGridView;
            logDataGridView.Rows.Clear();
            errorDataGridView.Rows.Clear();
            groupBox = agroupBox;
            string tmp = "";
            string logType = "";
            int k = 0;
            if (logTreeView.SelectedNode != null)
            {
                tmp = logTreeView.SelectedNode.Text;
                k = tmp.IndexOf(" (");
                if (k != 0) logType = tmp.Substring(0, k);
                //EventLog ev = server.GetEventLog(logType);
                //int LastLogToShow = ev.Entries.Count;
                EventLogEntryCollection logEntries = server.GetEventLogEntries(logType);
                int LastLogToShow = logEntries.Count;
                if (LastLogToShow <= 0)
                {
                    string message = "В журнале: " + logType + " отсутствуют записи";
                    string caption = "Просмотр журналов событий";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // чтение выбранного журнала
                    groupBox.Text = "Просмотр журнала " + logType;
                    int i = 0;
                    int itog = 0;
                    int warning = 0;
                    int error = 0;


                    for (i = 0; i < LastLogToShow; i++)
                    {
                        //EventLogEntry CurrentEntry = ev.Entries[i];
                        EventLogEntry CurrentEntry = logEntries[i];
                        //switch  (CurrentEntry.EventID)
                        // {
                        //     case : logDataGridView.Rows.Add(CurrentEntry.EventID, "Ошибка", CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                        //         itog++;
                        //          break;         
                        //  }
                        if ((CurrentEntry.EventID == 4) || (CurrentEntry.EventID == 472) || (CurrentEntry.EventID == 477) || (CurrentEntry.EventID == 517) ||
                            (CurrentEntry.EventID == 624) || (CurrentEntry.EventID == 535) || (CurrentEntry.EventID == 533) || (CurrentEntry.EventID == 529) ||
                            (CurrentEntry.EventID == 632) || (CurrentEntry.EventID == 539) || (CurrentEntry.EventID == 534) || (CurrentEntry.EventID == 531) ||
                            (CurrentEntry.EventID == 636) || (CurrentEntry.EventID == 660) || (CurrentEntry.EventID == 6806) || (CurrentEntry.EventID == 4645) ||
                            (CurrentEntry.EventID == 642) || (CurrentEntry.EventID == 675) || (CurrentEntry.EventID == 681) || (CurrentEntry.EventID == 4728) ||
                            (CurrentEntry.EventID == 644) || (CurrentEntry.EventID == 676) || (CurrentEntry.EventID == 1102) || (CurrentEntry.EventID == 4732) ||
                            (CurrentEntry.EventID == 4740) || (CurrentEntry.EventID == 4756) || (CurrentEntry.EventID == 4768) || (CurrentEntry.EventID == 4776) ||
                            (CurrentEntry.EventID == 4738) || (CurrentEntry.EventID == 4733) || (CurrentEntry.EventID == 630))
                        {
                            logDataGridView.Rows.Add(CurrentEntry.EventID, "Обратите внимание", CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                            itog++;
                            warning++;

                        }
                        if ((CurrentEntry.EventID == 200) || (CurrentEntry.EventID == 4124) || (CurrentEntry.EventID == 4226) || (CurrentEntry.EventID == 7901) ||
                            (CurrentEntry.EventID == 12294) || (CurrentEntry.EventID == 9095) || (CurrentEntry.EventID == 9097) || (CurrentEntry.EventID == 7023) ||
                            (CurrentEntry.EventID == 6183) || (CurrentEntry.EventID == 55) || (CurrentEntry.EventID == 1066) || (CurrentEntry.EventID == 6008) || (CurrentEntry.EventID == 861))
                        {
                            logDataGridView.Rows.Add(CurrentEntry.EventID, "ОШИБКА!!!", CurrentEntry.TimeGenerated.ToString(), CurrentEntry.MachineName.ToString(), CurrentEntry.Message);
                            itog++;
                            error++;
                        }



                    }
                    if (itog == 0)
                        MessageBox.Show("Опасных записей в журнале не найдено", "Мониторинг событий ИБ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Всего найдено   " + itog + "   записей" + "\r\n" + "Из них   " + warning + "        с пометкой 'Обратите внимание'" + "\r\n" + "              " + error + "        с пометкой 'ОШИБКА!!!'",
                        "Результат проверки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //ev.Close();
            }
            else MessageBox.Show("Ни один журнал не выбран", "Просмотр журналов событий", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
