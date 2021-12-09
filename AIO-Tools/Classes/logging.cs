using System;
using System.IO;
using AIO_Tools.Classes;

namespace AIO_Tools
{
    class Logging
    {
        #region Logging
        private static string LoggingTXT = "Data\\LOGS\\logging.txt";
        public static void WriteLog(string strLog)
        {
            FileInfo logFileInfo = new FileInfo(LoggingTXT);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now + " | INFO | " + strLog);
        }
        public static void SpecificLog(string strLog, string logType)
        {
            FileInfo logFileInfo = new FileInfo(LoggingTXT);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now + " | " + logType + " | " + strLog);
        }
        public static void DebugLog(string strLog)
        {
            DebugLog(strLog,"DEBUG");
        }
        public static void DebugLog(string strLog, string logType)
        {
            INI ini = new INI();
            if (ini.IsDebug() == true)
            {
                FileInfo logFileInfo = new FileInfo(LoggingTXT);
                DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists) logDirInfo.Create();
                using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
                using StreamWriter log = new StreamWriter(fileStream);
                log.WriteLine(DateTime.Now + " | " + logType + " | " + strLog);
            }
        }
        #endregion
        #region Write Path txt
        private static string TXTPath = "Data\\path.txt";
        public static void PathTXT(string path)
        {
            if (File.Exists(TXTPath))
            {
                File.Delete(TXTPath);
            }
            FileInfo logFileInfo = new FileInfo(TXTPath);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists)
            {
                logDirInfo.Create();
            }
            using FileStream fileStream = new FileStream(TXTPath, FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(path);
        }
        #endregion
    }
}
