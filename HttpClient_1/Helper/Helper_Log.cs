using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HttpClient_1
{
    /// <summary>
    /// 保存日志类
    /// </summary>
    public static class Helper_log
    {
        static string path_log = AppDomain.CurrentDomain.BaseDirectory;

        static ILog log = GetILog();
        static ILog CurrentWarningsLog = GetCurrentWarningsILog();
        static ILog WarningTotalDetailLog = GetWarningTotalDetailILog();
        public static ILog ElectricLog = GetElectricILog();

        static ILog errorLog = GetErrorILog();

        /// <summary>
        /// 实例化日志类
        /// </summary>
        /// <returns></returns>
        private static ILog GetILog()
        {
            string filePath = Path.Combine(path_log, "log4net.config");
            var config = new FileInfo(filePath);
            XmlConfigurator.ConfigureAndWatch(config);

            return LogManager.GetLogger("hdams222");
        }

        private static ILog GetCurrentWarningsILog()
        {
            string filePath = Path.Combine(path_log, "log4net.config");
            var config = new FileInfo(filePath);
            XmlConfigurator.ConfigureAndWatch(config);

            return LogManager.GetLogger("CurrentWarnings");
        }

        private static ILog GetWarningTotalDetailILog()
        {
            string filePath = Path.Combine(path_log, "log4net.config");
            var config = new FileInfo(filePath);
            XmlConfigurator.ConfigureAndWatch(config);

            return LogManager.GetLogger("WarningTotalDetail");
        }

        private static ILog GetElectricILog()
        {
            string filePath = Path.Combine(path_log, "log4net.config");
            var config = new FileInfo(filePath);
            XmlConfigurator.ConfigureAndWatch(config);
            
            return LogManager.GetLogger("Electric");
        }

        private static ILog GetErrorILog()
        {
            //string filePath = Path.Combine(path_log, "log4net.config");
            //var config = new FileInfo(filePath);
            //XmlConfigurator.ConfigureAndWatch(config);
            return LogManager.GetLogger("hdams");
        }


        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="message"></param>
        public static void Write_log(string message)
        {
            log.Info(message);           
        }

        public static void WriteCurrentWarnings_log(string message)
        {
            CurrentWarningsLog.Info(message);
        }

        public static void WriteWarningTotalDetail_log(string message)
        {
            WarningTotalDetailLog.Info(message);
        }

        public static void WriteElectric_log(string message)
        {
            ElectricLog.Info(message);
        }

        public static void Write_Error(string message)
        {
            errorLog.Error(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iLog"></param>
        /// <param name="fileName"></param>
        public static void ChangeLog4netLogFileName(log4net.ILog iLog, string fileName)
        {
            log4net.Core.LogImpl logImpl = iLog as log4net.Core.LogImpl;
            if (logImpl != null)
            {
                log4net.Appender.AppenderCollection ac = ((log4net.Repository.Hierarchy.Logger)logImpl.Logger).Appenders;
                for (int i = 0; i < ac.Count; i++)
                {    //这里我只对RollingFileAppender类型做修改
                    log4net.Appender.RollingFileAppender rfa = ac[i] as log4net.Appender.RollingFileAppender;
                    if (rfa != null)
                    {
                        rfa.File = fileName;
                        if (!System.IO.File.Exists(fileName))
                        {
                            System.IO.File.Create(fileName);
                        }
                        //更新Writer属性
                        rfa.Writer = new System.IO.StreamWriter(rfa.File, rfa.AppendToFile, rfa.Encoding);
                    }
                }
            }
        }


    }
}


            //log4net.Layout.PatternLayout layout = new log4net.Layout.PatternLayout("%m%n");
            //log4net.Appender.FileAppender appender = new log4net.Appender.FileAppender(layout, @"Logs\Electric\test.csv", true);
            //log4net.Config.BasicConfigurator.Configure(appender);
            //ILog Testlog = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            //Testlog.Info(message);
            //LogManager.Shutdown();