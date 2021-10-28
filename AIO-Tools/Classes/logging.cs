using System;
using System.IO;

namespace AIO_Tools
{
    class Logging
    {
        #region Logging
        public static void WriteLog(string strLog)
        {
            FileInfo logFileInfo = new FileInfo("Data\\LOGS\\logging.txt");
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using FileStream fileStream = new FileStream("Data\\LOGS\\logging.txt", FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now + " | INFO | " + strLog);
        }
        public static void SpecificLog(string strLog, string logType)
        {
            FileInfo logFileInfo = new FileInfo("Data\\LOGS\\logging.txt");
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using FileStream fileStream = new FileStream("Data\\LOGS\\logging.txt", FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now + " | " + logType + " | " + strLog);
        }
        #endregion
        #region Write Path txt
        public static void PathTXT(string path)
        {
            if (File.Exists("Data\\path.txt"))
            {
                File.Delete("Data\\path.txt");
            }
            FileInfo logFileInfo = new FileInfo("Data\\path.txt");
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists)
            {
                logDirInfo.Create();
            }
            using FileStream fileStream = new FileStream("Data\\path.txt", FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(path);
        }
        #endregion
    }
}
