using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActAud
{
    public class MonServer
    {
        private IMonService monService;

        public string GetName()
        {
            try
            {
                return monService.GetServerName();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public bool IsConnected
        {
            get
            {
                try
                {
                    return monService.TestConnection();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public byte[] IPaddr
        {
            get
            {
                try
                {
                    return monService.GetServerIP();
                }
                catch (Exception ex)
                {
                    return new byte[1];
                }
            }
        }

        public MonServer(IMonService _monService)
        {
            monService = _monService;
        }

        public EventLogEntryCollection GetEventLogEntries(string logType)
        {
            try
            {
                return monService.GetEventLogEntries(logType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public FileSystemWatcher GetFileSystemWatcher()
        {
            try
            {
                return monService.GetFileSystemWatcher();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public EventLog[] GetEventLogs()
        {
            try
            {
                return monService.GetEventLogs();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public FolderBrowserDialog GetFolderBrowserDIalog()
        {
            try
            {
                return monService.GetFolderBrowserDIalog();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string CheckDevices()
        {
            try
            {
                return monService.CheckDevices();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
