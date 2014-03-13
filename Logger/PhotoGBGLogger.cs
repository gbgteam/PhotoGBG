using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Logger
{
    public class PhotoGBGLogger
    {
        public static string TransformExceptionToString(Exception ex)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Server error: ");
            str.Append(" Exception: ");
            str.AppendLine(ex.Message);

            if (ex.InnerException !=null)
            {
                str.Append("InnerException: ");
                str.AppendLine(ex.InnerException.Message);
            }

            if (ex.StackTrace != null)
            {
                str.Append("StackTrace:");
                str.AppendLine(ex.StackTrace.ToString());
            }
            return str.ToString();
        }


        //this will post to azure Storage the error from server
        public static void Log(string Message)
        {
            string ipAddress;
            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Request != null)
            {
                ipAddress = System.Web.HttpContext.Current.Request.UserHostAddress;
            }
            else ipAddress = "NA";
            var log = LogManager.GetLogger("server-app");
            //LoggingEvent logEvent = new LoggingEvent(typeof(PhotoGBGLogger),log.Logger.Repository,log.Logger.Name,Level.Info, Message,null);
            //logEvent.Properties[ipAddress] = ipAddress;
            //log.Logger.Log(logEvent);
        }
    }
}
