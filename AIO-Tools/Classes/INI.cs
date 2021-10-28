using IniParser;
using IniParser.Model;

namespace AIO_Tools.Classes
{
    class INI
    {
        #region Config
        public static void SetUserName(string _username)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            data["User"]["name"] = _username;
            parserdata.WriteFile("Data\\Config\\Config.ini", data);
        }
        public static string UserName;
        public string GetUserName()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            UserName = data["User"]["name"];
            return UserName;
        }

        public static void SetFolder(string _folder)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            data["User"]["savefolder"] = _folder;
            parserdata.WriteFile("Data\\Config\\Config.ini", data);
        }
        public static string Folder;
        public string GetFolder()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            Folder = data["User"]["savefolder"];
            return Folder;
        }

        public static bool SubPaths;
        public bool GetSubPaths()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            string SubPathsSTR = data["GeneralConfiguration"]["SubPaths"];
            SubPaths = bool.Parse(SubPathsSTR);
            return SubPaths;
        }

        public static bool SavePath;
        public bool GetSavePath()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            string SavePathSTR = data["GeneralConfiguration"]["SavePath"];
            SavePath = bool.Parse(SavePathSTR);
            return SavePath;
        }

        public bool GetNewFeature()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            string NewFeatureStr = data["GeneralConfiguration"]["NewFeature"];
            bool NewFeature = bool.Parse(NewFeatureStr);
            return NewFeature;
        }

        public bool GetUI_MODE()
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            string UI_ModeStr = data["UI"]["lightmode"];
            bool UI_Mode = bool.Parse(UI_ModeStr);
            return UI_Mode;
        }
        public static void Set_tempdownloaded(string _tempdownloaded)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile("Data\\Config\\Config.ini");
            data["User"]["tempdownloaded"] = _tempdownloaded;
            parserdata.WriteFile("Data\\Config\\Config.ini", data);
        }
        #endregion
    }
}
