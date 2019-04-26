/*----------------------------------------------------------------

// 文件名：LogHelper.cs
// 功能描述：日志操作
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HST.Utillity
{
    /// <summary>
    /// Utility for logging messages with log4net.
    /// Retrieves an appropriate logger and formats standardized messages for logging.
    /// <seealso cref="log4net"/>
    /// </summary>
    /// <remarks>
    /// To create different logging rules by module or class, extend this class and override its
    /// LOGGER_NAME to retrieve a different logger.
    /// </remarks>
    public class Logger
    {

        // The name of the logger to use for logging in the Web app.
        protected const String LOGGER_NAME = "HST.Art";

        // Static handle to the logger for use in all methods.
        protected static log4net.ILog logger = log4net.LogManager.GetLogger(LOGGER_NAME);

        /// <summary>
        /// Formats a standardized message string for logging.
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <returns>String suitable for logging</returns>
        protected static String FormatMessage(object caller, object message)
        {
            String strMessage = "[" + caller.GetType().FullName + "]: " + message.ToString();
            return strMessage;
        }

        /// <summary>
        /// Logs a debug message using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        public static void Debug(object caller, object message)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Debug("DEBUG: " + strMessage);
        }

        /// <summary>
        /// Logs a debug message and exception stack strace using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <param name="e">
        /// Exception to log.  The exception stack trace will be added to the log.
        /// </param>
        public static void Debug(object caller, object message, System.Exception e)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Debug("DEBUG: " + strMessage, e);
        }

        /// <summary>
        /// Logs an info message using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        public static void Info(object caller, object message)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Info("INFO : " + strMessage);
        }
        /// <summary>
        /// Logs an info message and exception stack strace using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <param name="e">
        /// Exception to log.  The exception stack trace will be added to the log.
        /// </param>
        public static void Info(object caller, object message, System.Exception e)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Info("INFO : " + strMessage, e);
        }

        /// <summary>
        /// Logs a warning message using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        public static void Warn(object caller, object message)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Warn("WARN : " + strMessage);
        }

        /// <summary>
        /// Logs a warning message and exception stack strace using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <param name="e">
        /// Exception to log.  The exception stack trace will be added to the log.
        /// </param>
        public static void Warn(object caller, object message, System.Exception e)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Warn("WARN : " + strMessage, e);
        }

        /// <summary>
        /// Logs an error message using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        public static void Error(object caller, object message)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Error("ERROR: " + strMessage);
        }

        /// <summary>
        /// Logs an error message and exception stack strace using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <param name="e">
        /// Exception to log.  The exception stack trace will be added to the log.
        /// </param>
        public static void Error(object caller, object message, System.Exception e)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Error("ERROR: " + strMessage, e);
        }

        /// <summary>
        /// Logs a fatal message using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        public static void Fatal(object caller, object message)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Fatal("FATAL: " + strMessage);
        }

        /// <summary>
        /// Logs a fatal message and exception stack strace using log4net
        /// </summary>
        /// <param name="caller">
        /// Reference to the calling object.
        /// </param>
        /// <param name="message">
        /// Object representing the message to log.  Must implement an appropriate ToString() method.
        /// </param>
        /// <param name="e">
        /// Exception to log.  The exception stack trace will be added to the log.
        /// </param>
        public static void Fatal(object caller, object message, System.Exception e)
        {
            String strMessage = FormatMessage(caller, message);
            logger.Fatal("FATAL: " + strMessage, e);
        }
    }
}
