using AIO_Tools.Classes;
using System.Diagnostics;

namespace AIO_Tools
{
    class Download
    {
        #region Get Set Content
        //Manifest
        private static string _ManifestContent;
        public string GetManifestContent()
        {
            return _ManifestContent;
        }
        public void SetManifestContent(string newmanifest)
        {
            _ManifestContent = newmanifest;
        }
        //DepotContent
        private static string _DepotContent;
        public void SetDepotContent(string newdepot)
        {
            _DepotContent = newdepot;
        }
        public string GetDepotContent()
        {
            return _DepotContent;
        }
        //SDKContent
        private static string _SDKContent;
        public string GetSDKContent()
        {
            return _SDKContent;
        }
        public void SetSDKContent(string newsdk)
        {
            _SDKContent = newsdk;
        }
        //SDK Manifest
        private static string _SDKManifest;
        public void SetSDKManifest(string newsdkmanifest)
        {
            _SDKManifest = newsdkmanifest;
        }
        public string GetSDKManifest()
        {
            return _SDKManifest;
        }
        //UserName
        private static string _UserName;
        public string GetName()
        {
            return _UserName;
        }
        public void SetName(string newname)
        {
            _UserName = newname;
        }
        private static string _AppID;
        public string GetAppID()
        {
            return _AppID;
        }
        public void SetAppID(string newappid)
        {
            _AppID = newappid;
        }
        private static string _PlazaName;
        public string GetPlazaName()
        {
            return _PlazaName;
        }
        public void SetPlazaName(string newplazaname)
        {
            _PlazaName = newplazaname;
        }
        #endregion
        #region Downloading
        public static void Downloading(int Key)
        {
            Download dw = new Download();
            string Choosed = dw.KeyChoose(Key);
            Logging.WriteLog("Download send to DL.bat: " + Choosed);
            string StartArgName = "/C cd Data & DL.bat " + Choosed;
            // start downloading
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = StartArgName;
            process.Start();
            Logging.WriteLog("Download Finished");
        }

        public string KeyChoose(int Key)
        {
            Download dw = new Download();
            string depotcontent = dw.GetDepotContent();
            string manifestcontent = dw.GetManifestContent();
            string sdkmanifest = dw.GetSDKManifest();
            string username = dw.GetName();
            string sdkcontent = dw.GetSDKContent();
            string AppID = dw.GetAppID();
            string PlazaName = dw.GetPlazaName();
            string ChoosedKey;
            switch (Key)
            {
                case 1:
                    //ChoosedKey = "Extra";
                    ChoosedKey = "Extra " + AppID + " " + depotcontent + " " + manifestcontent + " " + username;
                    return ChoosedKey;
                case 2:
                    //ChoosedKey = "Normal";
                    ChoosedKey = "Normal " + sdkcontent + " " + sdkmanifest + " 359551 " + manifestcontent + " " + username + " " + PlazaName;
                    return ChoosedKey;
                case 3:
                    //ChoosedKey = "Compressed";
                    ChoosedKey = "Compressed " + sdkcontent + " " + sdkmanifest + " 359551 " + manifestcontent + " " + username + " f1.txt f2.txt " + PlazaName;
                    return ChoosedKey;
                default:
                    return null;
            }
        }
        #endregion
    }
}