using IniParser;
using IniParser.Model;

namespace AIO_Tools.Classes
{
    class INI
    {
        #region Config
        //UserName
        public static void SetUserName(string _username)
        {
            SetToINI("User", "name",_username);
        }
        public string GetUserName()
        {
            string UserName = GetFromINI("User", "name");
            return UserName;
        }
        //Folder
        public static void SetFolder(string _folder)
        {
            SetToINI("User", "savefolder", _folder);
        }
        public string GetFolder()
        {
            string Folder = GetFromINI("User","savefolder");
            return Folder;
        }
        //Bools
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
        public bool IsDebug()
        {
            string Debug_Str = GetFromINI("GeneralConfiguration", "Debug");
            bool B_Debug = bool.Parse(Debug_Str);
            return B_Debug;
        }
        //tempdownloaded
        public static void Set_tempdownloaded(string _tempdownloaded)
        {
            SetToINI("User", "tempdownloaded", _tempdownloaded);
        }
        public string Get_tempdownloaded()
        {
            string tmp_Folder = GetFromINI("User", "tempdownloaded");
            return tmp_Folder;
        }
        //InstalledSeasons_Path
        public static void SetInstalledSeason_Path(string _SeasonName,string _Path)
        {
            SetToINI("InstalledSeasons", _SeasonName + "_Path", _Path);
        }
        public string GetInstalledSeason_Path(string _SeasonName)
        {
            string SeasonFolder = GetFromINI("InstalledSeasons", _SeasonName+ "_Path");
            return SeasonFolder;
        }
        public static void RemoveInstalledSeason_Path(string _SeasonName)
        {
            RemoveINI("InstalledSeasons", _SeasonName + "_Path");
        }
        //InstalledSeasons_I
        public static void SetInstalledSeason_I(string _SeasonName)
        {
            SetToINI("InstalledSeasons", _SeasonName, "Installed");
        }
        public string GetInstalledSeason_I(string _SeasonName)
        {
            string SeasonFolder = GetFromINI("InstalledSeasons", _SeasonName);
            return SeasonFolder;
        }
        public static void RemoveInstalledSeason_I(string _SeasonName)
        {
            RemoveINI("InstalledSeasons", _SeasonName);
        }
        #endregion
        #region String
        private static string ConfigINI = "Data\\Config\\Config.ini";
        #endregion
        #region Set/Get/Remove to INI
        private string GetFromINI(string Category, string Name)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            string ReadedStuff = data[Category][Name];
            if (string.IsNullOrEmpty(ReadedStuff))
            {
                return null;
            }
            return ReadedStuff;
        }
        private static void SetToINI(string Category, string Name,string Data)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            data[Category][Name] = Data;
            parserdata.WriteFile(ConfigINI, data);
        }
        private static void RemoveINI(string Category, string Name)
        {
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            data[Category].RemoveKey(Name);
            parserdata.WriteFile(ConfigINI, data);
        }
        /*
        private string GetFromINI_v2(string Category, string Name)
        {
            string out_value;
            var parserdata = new FileIniDataParser();
            IniData data = parserdata.ReadFile(ConfigINI);
            string formatted = string.Format("{0}.{1}", Category, Name);
            bool x = data.TryGetKey(formatted, out out_value);
            if (x == false)
            {
                return null;
            }
            return out_value;
        }
        */
        #endregion
    }
}
