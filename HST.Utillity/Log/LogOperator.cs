/*----------------------------------------------------------------

// 文件名：LogHelper.cs
// 功能描述：日志操作
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/
using System;
using log4net;
using Newtonsoft.Json;

namespace HST.Utillity
{
    /// <summary>
    /// 日志操作
    /// </summary>
    public class LogHelper
    {
       
       public static void Debug(LoggerType loggerType, object message, Exception e)
        {
            var logger = LogManager.GetLogger(loggerType.ToString());
            logger.Debug(SerializeObject(message), e);
        }

        public static void Error(LoggerType loggerType, object message, Exception e)
        {
            ILog logger = LogManager.GetLogger(loggerType.ToString());
            logger.Error(SerializeObject(message), e);
        }

        public static void Info(LoggerType loggerType, object message, Exception e)
        {
            var logger = LogManager.GetLogger(loggerType.ToString());
            logger.Info(SerializeObject(message), e);
        }

        public static void Fatal(LoggerType loggerType, object message, Exception e)
        {
            var logger = LogManager.GetLogger(loggerType.ToString());
            logger.Fatal(SerializeObject(message), e);
        }

        public static void Warn(LoggerType loggerType, object message, Exception e)
        {
            var logger = LogManager.GetLogger(loggerType.ToString());
            logger.Warn(SerializeObject(message), e);
        }

        private static object SerializeObject(object message)
        {
            if (message is string || message == null)
                return message;
            else
                return JsonConvert.SerializeObject(message, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }
    }

    public enum LoggerType
    {
        WebExceptionLog,
        ServiceExceptionLog
    }
}