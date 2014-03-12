using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Table.DataServices;

namespace Logger
{
    public class LogEntry : TableServiceEntity
    {
        public LogEntry()
        {
            var now = DateTime.UtcNow;
            PartitionKey = string.Format("{0:yyyy-MM}",now);
            RowKey = string.Format("{0:dd HH:mm:ss.fff}-{1}",now, Guid.NewGuid());
        }

        #region Fields
        public string Message { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Domain { get; set; }
        public string ThreadName { get; set; }
        public string Identity { get; set; }
        public string RoleInstance { get; set; }
        public string DeploymentId { get; set; }
        #endregion
    }
}
