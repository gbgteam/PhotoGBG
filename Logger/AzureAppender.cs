using log4net.Appender;
using log4net.Core;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Logger
{
    public class AzureAppender : AppenderSkeleton
    {
        public string TableStorageConnectionStringName { get; set; }
        private LogServiceContext _ctx;
        private string _tableEndPoint;
        public override void ActivateOptions()
        {
            base.ActivateOptions();
            var cloudStorage = CloudStorageAccount.Parse(RoleEnvironment.GetConfigurat);
            _tableEndPoint = cloudStorage.TableEndpoint.AbsoluteUri;
            CloudTableClient.CreateTablesFromModel(typeof(LogServiceContext), _tableEndPoint, cloudStorage.Credentials);
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            Action doWriteToLog = () =>
            {
                try
                {
                }
                catch (DataServiceRequestException e)
                {
                    ErrorHandler.Error(string.Format("{0}:Could not write log entry to {1} : {2}",
                        GetType().AssemblyQualifiedName,_tableEndPoint,e.Message);
                }
            };
            doWriteToLog.BeginInvoke(null,null);
        }
    }
}
 */
