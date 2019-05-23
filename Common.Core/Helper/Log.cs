using NLog;
using System;

namespace Common.Core.Helper
{
    public class Log
    {
        private static Logger log = NLog.LogManager.GetCurrentClassLogger();
        
        public static void Error(Exception ex)
        {
            log.Error(ex);
        }
    }
}
