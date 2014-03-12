using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class LogServiceContext : TableServiceContext
    {
        public LogServiceContext(string baseAddress, StorageCredentials credentials)
            : base(baseAddress, credentials)
        {
            
        }

        internal void Log(LogEntry logEntry)
        {
            AddObject("LogEntries", logEntry);
            SaveChanges();
        }
    }
}
