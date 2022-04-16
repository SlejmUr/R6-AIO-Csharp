using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace AIO_Tools.Classes
{
    class GettingNet
    {
        #region Start
        public static void Starting()
        {
            DB_Download();
            DepotDownload();
            DL_Download();
            INI_Download();
            All_Download();
            Logging.SpecificLog("Downloaded all stuff that needed", "Loading/Starting");
        }
        #endregion
        #region Download zips
        public static void DepotDownload()
        {
            if (!Directory.Exists("AIO_Data\\DepotDownloader"))
            {
                //Download
                string Download = "https://github.com/SteamRE/DepotDownloader/releases/download/DepotDownloader_2.4.5/depotdownloader-2.4.5.zip";
                string zipname = "depotdownloader-2.4.5.zip";
                string extractPath = "AIO_Data\\DepotDownloader";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, zipname);
                //Extract
                ZipFile.ExtractToDirectory(zipname, extractPath);
                //Delete
                File.Delete(zipname);
                Logging.WriteLog("DepotDownloader not Exist, Download");
            }
        }
        public static void PlazaDownload()
        {
            if (!Directory.Exists("AIO_Data\\Plazas"))
            {
                //Download
                string Download = "https://slejmur.keybase.pub/Plazas.zip?dl=1";
                string zipname = "Plazas.zip";
                //string extractPath = "Plazas";
                string extractPath = Directory.GetCurrentDirectory() + "\\AIO_Data\\Plazas";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, zipname);
                //Extract
                ZipFile.ExtractToDirectory(zipname, extractPath);
                //Delete
                File.Delete(zipname);
                Logging.WriteLog("Basic Plazas not Exist, Download");
            }
        }

        public static void StreamingInstallDownload()
        {
            if (!Directory.Exists("AIO_Data\\StreamingInstalls"))
            {
                //Download 
                string Download = "https://slejmur.keybase.pub/StreamingInstalls.zip?dl=1";
                string zipname = "StreamingInstalls.zip";
                //string extractPath = "Plazas";
                string extractPath = Directory.GetCurrentDirectory() + "\\AIO_Data";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, zipname);
                //Extract
                ZipFile.ExtractToDirectory(zipname, extractPath);
                //Delete
                File.Delete(zipname);
                Logging.WriteLog("StreamingInstalls not Exist, Download");
                AltUI.Forms.DarkMessageBox.ShowMessage("Please check the\nCompressed INFO!", "Info");
            }
        }
        #endregion
        #region Download DB, bat and ini
        public static void DL_Download()
        {
            if (!File.Exists("AIO_Data\\DL.bat"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/DL.bat";
                string filename = "DL.bat";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                File.Move(filename, "AIO_Data\\" + filename);
                Logging.WriteLog("DL.bat not Exist, Download");
            }
        }
        public static void DLFast_Check(bool isChecked)
        {

            if (File.Exists("AIO_Data\\DL.bat"))
            {
                File.Delete("AIO_Data\\DL.bat");
            }
            if (isChecked == true)
            {
                DLFast_Download();
            }
            else
            {
                DL_Download();
            }
        }
        public static void DLFast_Download()
        {
            if (!File.Exists("AIO_Data\\DL.bat"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/DL_fast.bat";
                string filename = "DL.bat";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                File.Move(filename, "AIO_Data\\" + filename);
                Logging.WriteLog("DL.bat not Exist, Download (Fast version)");
            }
        }
        public static void DB_Download()
        {
            if (!File.Exists("AIO_Data\\DataBase\\datas.db"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/datas.db";
                string filename = "datas.db";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                if (!Directory.Exists("AIO_Data\\DataBase")) { Directory.CreateDirectory("AIO_Data\\DataBase"); }
                File.Move(filename, "AIO_Data\\DataBase\\" + filename);
                Logging.WriteLog("Datas.DB not Exist, Download");
            }
        }

        public static void All_Download()
        {
            if (!File.Exists("AIO_Data\\DataBase\\all.db"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/all.db";
                string filename = "all.db";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                if (!Directory.Exists("AIO_Data\\DataBase")) { Directory.CreateDirectory("AIO_Data\\DataBase"); }
                File.Move(filename, "AIO_Data\\DataBase\\" + filename);
                Logging.WriteLog("All.DB not Exist, Download");
            }
        }

        public static void INI_Download()
        {
            if (!File.Exists("AIO_Data\\Config\\config.ini"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/config.ini";
                string filename = "config.ini";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                if (!Directory.Exists("AIO_Data\\Config")) { Directory.CreateDirectory("AIO_Data\\Config"); }
                File.Move(filename, "AIO_Data\\Config\\" + filename);
                Logging.WriteLog("config.ini not Exist, Download");
            }
        }
        public static void Update_Download()
        {
            try
            {
                if (File.Exists("AIO_Data\\Update\\AIO-Tools.exe"))
                {
                    File.Delete("AIO_Data\\Update\\AIO-Tools.exe");
                }
            }
            finally
            {
                if (!File.Exists("AIO_Data\\Update\\AIO-Tools.exe"))
                {
                    //Download
                    string Download = "https://github.com/SlejmUr/R6-AIO-Csharp/releases/latest/download/AIO-Tools.exe";
                    string filename = "AIO-Tools_New.exe";
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(Download, filename);
                    if (!Directory.Exists("AIO_Data\\Update")) { Directory.CreateDirectory("AIO_Data\\Update"); }
                    File.Move(filename, "AIO_Data\\Update\\AIO-Tools.exe");
                    Logging.WriteLog("Update Exe not Exist, Download");
                    Update_DL_Download();
                    Logging.WriteLog("Please update to new version");
                }
            }
        }
        public static void Update_DL_Download()
        {
            if (!File.Exists("AIO-Updater.bat"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/AIO-Updater.bat";
                string filename = "AIO-Updater.bat";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
                Logging.WriteLog("Update Batch not Exist, Download");
            }
        }
        #endregion
        #region Filelist and Desc,etc
        public static void FileList2_Download(string ContentName)
        {
            if (File.Exists("AIO_Data\\f2.txt"))
            {
                File.Delete("AIO_Data\\f2.txt");
            }
            string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/Compressed_txt/" + ContentName + "Content.txt";
            string filename = "f2.txt";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(Download, filename);
            File.Move(filename, "AIO_Data\\" + filename);
            Logging.WriteLog("f2.txt Downloaded: " + ContentName);
        }
        public static void FileList1_Download(string ContentName, int SDK)
        {
            string SDKNAME = "";
            if (File.Exists("AIO_Data\\f1.txt"))
            {
                File.Delete("AIO_Data\\f1.txt");
            }
            switch (SDK)
            {
                case 1:
                    SDKNAME = "SDK";
                    break;
                case 2:
                    SDKNAME = "RUS";
                    break;
                default:
                    break;
            }
            string Download = "https://github.com/SlejmUr/R6-AIOTool-Csharp/raw/main/Compressed_txt/" + ContentName + SDKNAME + ".txt";
            string filename = "f1.txt";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(Download, filename);
            File.Move(filename, "AIO_Data\\" + filename);
            Logging.WriteLog("f1.txt Downloaded: " + ContentName + SDKNAME);
        }
        public static string GetDesc(string versionname)
        {
            string helped = "https://raw.githubusercontent.com/SlejmUr/R6-AIOTool-Csharp/main/VersionDesc/" + versionname + ".txt";
            try
            {
                WebClient webclient = new WebClient();
                Stream stream = webclient.OpenRead(helped);
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                return content;

            }
            catch (WebException copyError)
            {
                Logging.WriteLog(copyError.Message + versionname);
            }
            return null;
        }
        public static string GetVersion()
        {
            string version = "https://raw.githubusercontent.com/SlejmUr/Versions/main/R6-AIO";
            try
            {
                WebClient webclient = new WebClient();
                Stream stream = webclient.OpenRead(version);
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadLine();
                return content;

            }
            catch (WebException copyError)
            {
                Logging.WriteLog(copyError.Message);
            }
            return Utils.Version;
        }


        public static Image SetIMG(string url)
        {
            try
            {
                if (url.Contains("http"))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] data = webClient.DownloadData(url);

                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            return Image.FromStream(mem);
                        }
                    }
                }
                else
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] data = webClient.DownloadData("https://raw.githubusercontent.com/SlejmUr/R6-AIOTool-Csharp/main/Pictures/" + url + ".jpg");

                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            return Image.FromStream(mem);
                        }
                    }
                }
            }
            catch (WebException copyError)
            {
                Logging.WriteLog(copyError.Message);
            }
            return Properties.Resources._base;
        }
        #endregion
    }
}
