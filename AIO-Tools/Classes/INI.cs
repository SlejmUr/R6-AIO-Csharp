using IniParser;
using IniParser.Model;

namespace AIO_Tools.Classes
{
    class INI
    {
        #region Config
        public static void SetUserName(string _username)
        {
            SetToINI("User", "name",_username);
        }
        public string GetUserName()
        {
            string UserName = GetFromINI("User", "name");
            return UserName;
        }
        public static void SetFolder(string _folder)
        {
            SetToINI("User", "savefolder", _folder);
        }
        public string GetFolder()
        {
            string Folder = GetFromINI("User","savefolder");
            return Folder;
        }
        public bool GetSubPaths()
        {
            string SubPathsSTR = GetFromINI("GeneralConfiguration", "SubPaths");
            bool SubPaths = bool.Parse(SubPathsSTR);
            return SubPaths;
        }
        public bool GetSavePath()
        {
            string SavePathSTR = GetFromINI("GeneralConfiguration", "SavePath");
            bool SavePath = bool.Parse(SavePathSTR);
            return SavePath;
        }
        public bool GetNewFeature()
        {
            string NewFeatureStr = GetFromINI("GeneralConfiguration", "NewFeature");
            bool NewFeature = bool.Parse(NewFeatureStr);
            return NewFeature;
        }
        public bool GetUI_MODE()
        {
            string UI_ModeStr = GetFromINI("UI", "lightmode");
            bool UI_Mode = bool.Parse(UI_ModeStr);
            return UI_Mode;
        }
        public static void Set_tempdownloaded(string _tempdownloaded)
        {
            SetToINI("User", "tempdownloaded", _tempdownloaded);
        }
        public bool IsDebug()
        {
            string Debug_Str = GetFromINI("GeneralConfiguration", "Debug");
            bool B_Debug = bool.Parse(Debug_Str);
            return B_Debug;
        }
        #endregion
        #region String
        private static string ConfigINI = "Data\\Config\\Config.ini";
        #endregion
        #region Set/Get to INI
        private string GetFromINI(string Category, string Name)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            string ReadedStuff = data[Category][Name];
            return ReadedStuff;
        }
        private static void SetToINI(string Category, string Name,string Data)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            data[Category][Name] = Data;
            parserdata.WriteFile(ConfigINI, data);
        }
        #endregion
    }
}
