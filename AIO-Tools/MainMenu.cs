using AIO_Tools.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO_Tools
{
    public partial class MainMenu : AltUI.Forms.DarkForm
    {
        #region Definitions and Start
        //strings for better use
        private string TextName;
        private string SeasonName = "";
        private string SubFolder;
        private string CompOrNormal;
        private string SDKName = "";
        private int SeasonContent = 1;
        private int VersionContent = 1;
        //importing from other class
        private readonly Download dw = new Download();
        private readonly INI ini = new INI();
        //ExtraDB integration
        private static readonly string datasdb = Utils.datasDB;

        public MainMenu()
        {
            InitializeComponent();
        }
        #endregion
        #region Load
        private void UI_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("MainMenu Loaded");
            NewStatesSET();
            DB_VersionDate();
            gettingcontent.Hide();
            // set to relesead content
            dw.SetSDKContent("377237");
            //UserName
            TextName = ini.GetUserName();
            dw.SetName(TextName);
            Logging.WriteLog(String.Format("Username validated as [{0}]", TextName));
        }
        #endregion
        #region ChangeSelections
        private void YearSelect(string S1URLName, string S2URLName, string S3URLName, string S4URLName, string[] test, string Extra = "0")
        {
            Season_1_Label.Text = test[0];
            Season_1.BackgroundImage = GettingNet.SetIMG(S1URLName);
            Season_2_Label.Text = test[1];
            Season_2.BackgroundImage = GettingNet.SetIMG(S2URLName);
            Season_3_Label.Text = test[2];
            Season_3.BackgroundImage = GettingNet.SetIMG(S3URLName);
            Season_4_Label.Text = test[3];
            Season_4.BackgroundImage = GettingNet.SetIMG(S4URLName);
            if (Extra.ToLower() == "vanilla")
            {
                Season_Special.Show();
                Season_Special_Label.Show();
                Season_Special_Label.Text = "Vanilla";
                Season_Special.BackgroundImage = GettingNet.SetIMG("vanilla");
            }
            else
            {
                Season_Special.Hide();
                Season_Special_Label.Hide();
            }
        }
        private void ChangeSelectionYears(object sender, EventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    ChangeSelectionY1(sender, e);
                    return;
                case 2:
                    ChangeSelectionY2(sender, e);
                    return;
                case 3:
                    ChangeSelectionY3(sender, e);
                    return;
                case 4:
                    ChangeSelectionY4(sender, e);
                    return;
                case 5:
                    ChangeSelectionY5(sender, e);
                    return;
                case 6:
                    ChangeSelectionY6(sender, e);
                    return;
                case 7:
                    ChangeSelectionY7(sender, e);
                    return;
                default:
                    break;
            }
        }
        private void ChangeSelectionY1(object sender, EventArgs e)
        {
            SeasonContent = 1;
            YearSelect("blackice", "dustline", "skullrain", "redcrow", new[] { "Black Ice", "Dust Line", "Skull Rain", "Red Crow" }, "vanilla");
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY2(object sender, EventArgs e)
        {
            SeasonContent = 2;
            YearSelect("velvetshell", "health", "bloodorchid", "whitenoise", new[] { "Velvet Shell", "Health", "Blood Orchid", "White Noise" });
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY3(object sender, EventArgs e)
        {
            SeasonContent = 3;
            string S1txt, S1IMG, S3txt, S3IMG;
            //Outbreak or Chimera
            //Mad House or Grim Sky
            if (VersionContent == 1)
            {
                S1txt = "Chimera";
                S1IMG = "chimera";
                S3txt = "Grim Sky";
                S3IMG = "grimsky";

            }
            else
            {
                S1txt = "OutBreak";
                S1IMG = "Outbreak";
                S3txt = "Mad House";
                S3IMG = "Mad_House_Event";
            }
            YearSelect(S1IMG, "parabellum", S3IMG, "windbastion", new[] { S1txt, "Para Bellum", S3txt, "Wind Bastion" });

            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY4(object sender, EventArgs e)
        {
            SeasonContent = 4;
            string S1txt, S1IMG,
                S2txt, S2IMG,
                S3txt, S3IMG,
                S4txt, S4IMG;
            //Rainbow Is Magic or Burnt Horizon
            //Showdown or Phantom Sight
            //Doctors Curse or Ember Rise
            //Road To S.I. or Shifting Tides
            if (VersionContent == 1)
            {
                S1txt = "Burnt Horizon";
                S1IMG = "burnthorizon";
                S2txt = "Phantom Sight";
                S2IMG = "phantomsight";
                S3txt = "Ember Rise";
                S3IMG = "emberrise";
                S4txt = "Shifting Tides";
                S4IMG = "shiftingtides";
            }
            else
            {
                S1txt = "Toy Rainbow";
                S1IMG = "rainbowismagic";
                S2txt = "Showdown";
                S2IMG = "Showdown";
                S3txt = "Doctors Curse";
                S3IMG = "doktorscurse";
                S4txt = "Road To S.I. 2020";
                S4IMG = "roadtosi";
            }
            YearSelect(S1IMG, S2IMG, S3IMG, S4IMG, new[] { S1txt, S2txt, S3txt, S4txt });
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY5(object sender, EventArgs e)
        {
            SeasonContent = 5;
            string S1txt = "", S1IMG = "",
                S2txt = "", S2IMG = "",
                S3txt = "", S3IMG = "",
                S4txt = "", S4IMG = "";
            //Grand Larceny or Void Edge
            //Road To S.I. 2021 or Neon Dawn
            //Telly or Shadow Legacy
            if (VersionContent == 1)
            {
                S1txt = "Void Edge";
                S1IMG = "voidedge";
                S2txt = "Steel Wave";
                S2IMG = "steelwave";
                S3txt = "Shadow Legacy";
                S3IMG = "shadowlegacy";
                S4txt = "Neon Dawn";
                S4IMG = "neondawn";

            }
            if (VersionContent == 2)
            {
                S2txt = "Mute [R6Global]";
                S2IMG = "Mute_protocol";
                S3txt = "Telly [R6Global]";
                S3IMG = "Telly";
                S1txt = "Grand Larceny";
                S1IMG = "GrandLarceny";
                S4txt = "Road To S.I. 2021";
                S4IMG = "roadtosi2021";
            }
            if (VersionContent == 3)
            {
                S2txt = "Mute Protocol";
                S2IMG = "Mute";
                S3txt = "Telly";
                S3IMG = "Telly";
                S1txt = "Grand Larceny";
                S1IMG = "GrandLarceny";
                S4txt = "Road To S.I. 2021";
                S4IMG = "roadtosi2021";
            }
            if (VersionContent == 4)
            {
                S3txt = "Shadow Legacy";
                S3IMG = "shadowlegacy";
                S2txt = "Mute Protocol";
                S2IMG = "Mute";
                S1txt = "Grand Larceny";
                S1IMG = "GrandLarceny";
                S4txt = "Road To S.I. 2021";
                S4IMG = "roadtosi2021";
            }
            YearSelect(S1IMG, S2IMG, S3IMG, S4IMG, new[] { S1txt, S2txt, S3txt, S4txt });
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY6(object sender, EventArgs e)
        {
            SeasonContent = 6;
            string S1txt, S1IMG,
                S2txt, S2IMG,
                S3txt, S3IMG,
                S4txt, S4IMG;
            if (VersionContent == 1)
            {
                S1txt = "Crimson Heist";
                S1IMG = "CrimsonHeist";
                S2txt = "North Star";
                S2IMG = "northstar";
                S3txt = "Crystal Guard";
                S3IMG = "CrystalGuard";
                S4txt = "High Calibre";
                S4IMG = "highcalibre";
            }
            else
            {
                S1txt = "Toy Rainbow 2";
                S1IMG = "rainbowismagic";
                S2txt = "Ev: Quarantine";
                S2IMG = "evn_quarantine";
                S3txt = "Event Mix";
                S3IMG = "Y6S3_EVN_MIX";
                S4txt = "Stadiums";
                S4IMG = "Stadiums";
            }
            YearSelect(S1IMG, S2IMG, S3IMG, S4IMG, new[] { S1txt, S2txt, S3txt, S4txt });
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        private void ChangeSelectionY7(object sender, EventArgs e)
        {
            SeasonContent = 7; //Not implemented yet.
            string S1txt, S1IMG,
                S2txt, S2IMG,
                S3txt, S3IMG,
                S4txt, S4IMG;
            S1txt = "Demon Veil";
            S1IMG = "DemonVeil";
            S2txt = "Placeholder2";
            S2IMG = "Placeholder";
            S3txt = "Placeholder3";
            S3IMG = "Placeholder";
            S4txt = "Placeholder4";
            S4IMG = "Placeholder";
            YearSelect(S1IMG, S2IMG, S3IMG, S4IMG, new[] { S1txt, S2txt, S3txt, S4txt });
            Logging.WriteLog("Selected Y" + SeasonContent);
        }
        #endregion
        #region SelectSeasons
        #region Season1
        private void SelectSeason1(object sender, MouseEventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    Logging.WriteLog("Black Ice Selected");
                    SeasonName = "Black Ice";
                    GetALL(SeasonName);
                    return;
                case 2:
                    Logging.WriteLog("Velvet Shell Selected");
                    SeasonName = "Velvet Shell";
                    GetALL(SeasonName);
                    return;
                case 3:
                    Logging.WriteLog("Chimera Selected");
                    SeasonName = "Chimera";
                    GetALL(SeasonName);
                    return;
                case 4:
                    Logging.WriteLog("Burnt Horizon Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Burnt Horizon";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Rainbow Is Magic";
                        GetALL(SeasonName);
                        return;
                    }
                case 5:
                    Logging.WriteLog("Void Edge Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Void Edge";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 2 | VersionContent == 3) //Version (Zero)
                    {
                        SeasonName = "Void Edge -MU";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 4) //Shey
                    {
                        SeasonName = "Void Edge -Shey";
                        GetALL(SeasonName);
                        return;
                    }
                    return;
                case 6:
                    Logging.WriteLog("Crimson Heist Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Crimson Heist";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Rainbow Is Magic 2";
                        GetALL(SeasonName);
                        return;
                    }
                case 7:
                    Logging.WriteLog("Demon Veil Selected");
                    SeasonName = "Demon Veil";
                    GetALL(SeasonName);
                    return;
                default:
                    operationDescription.Text = "No operation selected";
                    break;
            }
            return;
        }
        #endregion
        #region Season2
        private void SelectSeason2(object sender, MouseEventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    Logging.WriteLog("Dust Line Selected");
                    SeasonName = "Dust Line";
                    GetALL(SeasonName);
                    return;
                case 2:
                    Logging.WriteLog("Health Selected");
                    SeasonName = "Health";
                    GetALL(SeasonName);
                    return;
                case 3:
                    Logging.WriteLog("Para Bellum Selected");
                    if (VersionContent == 1 | VersionContent == 2 | VersionContent == 3)
                    {
                        SeasonName = "Para Bellum";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Para Bellum -Shey";
                        GetALL(SeasonName);
                        return;
                    }
                case 4:
                    Logging.WriteLog("Phantom Sight Selected");
                    SeasonName = "Phantom Sight";
                    GetALL(SeasonName);
                    return;
                case 5:
                    Logging.WriteLog("Steel Wave Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Steel Wave";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 2) //Version (Zero)
                    {
                        SeasonName = "MUTE Protocol";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 3 | VersionContent == 4) //Addon / event sometimes = zero | OMEGA steel wave +shey
                    {
                        SeasonName = "Mute [R6Global]";
                        GetALL(SeasonName);
                        return;
                    }
                    return;
                case 6:
                    Logging.WriteLog("North Star Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "North Star";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Nest Destruction";
                        GetALL(SeasonName);
                        return;
                    }
                default:
                    operationDescription.Text = "No operation selected";
                    break;
            }
            return;
        }
        #endregion
        #region Season3
        private void SelectSeason3(object sender, MouseEventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    Logging.WriteLog("Skull Rain Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Skull Rain";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Skull Rain2";
                        GetALL(SeasonName);
                        return;
                    }
                case 2:
                    Logging.WriteLog("Blood Orchid Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Blood Orchid";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 2 | VersionContent == 3) //Version (Zero)
                    {
                        SeasonName = "Blood Orchid -MU";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 4) //SHEY
                    {
                        SeasonName = "Blood Orchid -Shey";
                        GetALL(SeasonName);
                        return;
                    }
                    return;
                case 3:
                    Logging.WriteLog("Grim Sky Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Grim Sky";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Mad House";
                        GetALL(SeasonName);
                        return;
                    };
                case 4:
                    Logging.WriteLog("Ember Rise Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Ember Rise";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Doctors Curse";
                        GetALL(SeasonName);
                        return;
                    }
                case 5:
                    Logging.WriteLog("Shadow Legacy Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Shadow Legacy";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 2 | VersionContent == 4) //VERSION
                    {
                        SeasonName = "Sugar Fright [R6Global]";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 3) //Addon / event sometimes = zero | SUGAR FRIGHT
                    {
                        SeasonName = "Sugar Fright";
                        GetALL(SeasonName);
                        return;
                    }
                    return;
                case 6:
                    Logging.WriteLog("Crystal Guard Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Crystal Guard";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Event Mix";
                        GetALL(SeasonName);
                        return;
                    }
                default:
                    operationDescription.Text = "No operation selected";
                    break;
            }
            return;
        }
        #endregion
        #region Season4
        private void SelectSeason4(object sender, MouseEventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    Logging.WriteLog("Red Crow Selected");
                    SeasonName = "Red Crow";
                    GetALL(SeasonName);
                    return;
                case 2:
                    Logging.WriteLog("White Noise Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "White Noise";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "White Noise2";
                        GetALL(SeasonName);
                        return;
                    }
                case 3:
                    Logging.WriteLog("Wind Bastion Selected");
                    SeasonName = "Wind Bastion";
                    GetALL(SeasonName);
                    return;
                case 4:
                    Logging.WriteLog("Shifting Tides Selected");
                    SeasonName = "Shifting Tides";
                    GetALL(SeasonName);
                    return;
                case 5:
                    Logging.WriteLog("Neon Dawn Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "Neon Dawn";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 2) // Mystc/Zero
                    {
                        SeasonName = "Road To S.I. 2021 -RW";
                        GetALL(SeasonName);
                        return;
                    }
                    if (VersionContent == 3 | VersionContent == 4) //Event
                    {
                        SeasonName = "Road To S.I. 2021 -W";
                        GetALL(SeasonName);
                        return;
                    }
                    return;
                case 6:
                    Logging.WriteLog("High Calibre Selected");
                    if (VersionContent == 1) //Release
                    {
                        SeasonName = "High Calibre";
                        GetALL(SeasonName);
                        return;
                    }
                    else
                    {
                        SeasonName = "Stadiums";
                        GetALL(SeasonName);
                        return;
                    }
                default:
                    operationDescription.Text = "No operation selected";
                    break;
            }
            return;
        }
        #endregion
        #region Special
        private void SelectSeasonSpecial(object sender, MouseEventArgs e)
        {
            switch (SeasonContent)
            {
                case 1:
                    Logging.WriteLog("Vanilla Selected");
                    SeasonName = "Vanilla";
                    GetALL(SeasonName);
                    return;
                default:
                    operationDescription.Text = "No operation selected";
                    break;
            }
        }
        #endregion
        #endregion
        #region SQLite
        //SQlite things
        private void GetALL(string PickName)
        {
            gettingcontent.Show();
            gettingcontent.Text = "Getting Content";
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            //make some strings
            string manifest_content;
            string manifest_sku;
            //Get manifest content, foldername, desc
            //SELECT T1.manifest,T2.pickfoldername,T2.pickgamename FROM  ultimateDepot AS T1 LEFT JOIN pick as T2 ON T2.id = T1.pick_ID WHERE T2.pickname LIKE @pickname AND(T1.depotname LIKE \"Content\" OR T1.depotname LIKE @sku")
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT T1.manifest,T2.pickfoldername,T2.pickgetnet,T2.pickcrack FROM ultimateDepot AS T1 LEFT JOIN pick as T2 ON T2.id = T1.pick_ID WHERE T2.pickname LIKE @pickname AND(T1.depotname LIKE \"Content\" OR T1.depotid LIKE @sku)";
            cmd.Parameters.AddWithValue("@pickname", PickName);
            cmd.Parameters.AddWithValue("@sku", dw.GetSDKContent().ToString());
            cmd.Prepare();
            using (SQLiteDataReader rdr = cmd.ExecuteReader())
            {
                int i = 0;
                string[] s2 = new string[2];
                while (rdr.Read())
                {
                    s2[i] = rdr.GetValue(0).ToString();
                    SubFolder = rdr["pickfoldername"].ToString();
                    SDKName = rdr["pickgetnet"].ToString();
                    dw.SetPlazaName(rdr["pickcrack"].ToString());
                    i++;
                }
                rdr.Close();
                manifest_content = s2[0];
                dw.SetManifestContent(manifest_content);
                manifest_sku = s2[1];
                dw.SetSDKManifest(manifest_sku);
                Logging.DebugLog("Content: " + manifest_content + " Manifest SKU: " + manifest_sku, "Manifest Debug");
            }
            //Download F1 , F2
            if (!string.IsNullOrEmpty(SDKName))
            {
                GettingNet.FileList2_Download(SDKName);
                if (dw.GetSDKContent() == "377237") //WW
                {
                    GettingNet.FileList1_Download(SDKName, 1);
                }
                else //RUS
                {
                    GettingNet.FileList1_Download(SDKName, 2);
                }
            }
            operationDescription.Text = GettingNet.GetDesc(SDKName);
            stopw.Stop();
            Logging.SpecificLog("(GetALL) Time elapsed: " + stopw.Elapsed, "StopWatch");
            gettingcontent.Text = "Content Done";
            gettingcontent.Hide();
        }
        private void DB_VersionDate()
        {
            //DB Version and Date: 
            DB_DateVersion.Text = "DB Version and Date: ";
            //make some strings
            string Version;
            string Date;
            //Get DB version, Date
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT DB_Version,DB_Date FROM DB_Version";
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Version = rdr["DB_Version"].ToString();
                Date = rdr["DB_Date"].ToString();
                DB_DateVersion.Text = "DB Version and Date: " + Version + " | " + Date;
            }
            rdr.Close();
        }
        #endregion
        #region Set things from INI
        //NewFeature States
        private void NewStatesSET()
        {
            if (ini.GetNewFeature() == false)
            {
                //Logging.SpecificLog("Turned OFF", "NewFeatures");
            }
            else
            {
                Logging.SpecificLog("Turned ON (Currently nothing new)", "NewFeatures");
            }
        }
        #endregion
        #region Buttons Func
        private void Settings_Click(object sender, EventArgs e)
        {
            Forms.Settings Settings = new Forms.Settings();
            Settings.ShowDialog();
        }
        private void StartGameClicked(object sender, MouseEventArgs e)
        {
            Forms.StartingGame StartingGame = new Forms.StartingGame();
            StartingGame.Show();
        }
        private void SwichSDKContent(object sender, MouseEventArgs e)
        {
            if (dw.GetSDKContent() == "377237")
            {
                dw.SetSDKContent("377238");
                SKUlabel.Text = "RUS Content (for Russian users)";
                Logging.WriteLog("RUS Content Swapped");
                if (!string.IsNullOrEmpty(SeasonName))
                {
                    GetALL(SeasonName);
                }
                return;
            }
            else
            {
                dw.SetSDKContent("377237");
                SKUlabel.Text = "WW Content (for most users)";
                Logging.WriteLog("WW Content Swapped");
                if (!string.IsNullOrEmpty(SeasonName))
                {
                    GetALL(SeasonName);
                }
                return;
            }
        }
        private void Content_Swap(object sender, MouseEventArgs e)
        {
            operationDescription.Text = "Version Swapped, please re-select again :)";
            switch (VersionContent)
            {

                case 1:
                    VersionContent = 2;
                    Content_Label.Text = "MU Content";
                    Logging.WriteLog("Version Content Swapped");
                    ChangeSelectionYears(sender, e);
                    return;
                case 2:
                    VersionContent = 3;
                    Content_Label.Text = "Event Content";
                    Logging.WriteLog("Event Content Swapped");
                    ChangeSelectionYears(sender, e);
                    return;
                case 3:
                    VersionContent = 4;
                    Content_Label.Text = "Shey Content";
                    Logging.WriteLog("Shey Content Swapped");
                    ChangeSelectionYears(sender, e);
                    return;
                case 4:
                    VersionContent = 1;
                    Content_Label.Text = "Released Content";
                    Logging.WriteLog("Released Content Swapped");
                    ChangeSelectionYears(sender, e);
                    return;
                default:
                    return;
            }
        }
        #endregion
        #region Download buttons
        private void CompressedDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(SeasonName))
            {
                CompOrNormal = "Compressed";
                DownloadStart();
            }

        }
        public void DownClicked(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(SeasonName))
            {
                CompOrNormal = "Normal";
                DownloadStart();
            }
        }
        #endregion
        #region DownloadStates
        //LOT OF "IF,ELSE" STATES!
        //DownloadStates
        private void SavePathTrue()
        {
            if (ini.GetSubPaths() == false)
            {
                Logging.SpecificLog("SubFalse", "DownloadStates");
                SubPathsFalse_SaveTrue();
            }
            else
            {
                Logging.SpecificLog("SubTrue", "DownloadStates");
                SubPathsTrue_SaveTrue();
            }
        }
        private void SavePathFalse()
        {
            if (ini.GetSubPaths() == false)
            {
                Logging.SpecificLog("SubFalse", "DownloadStates");
                SubPathsFalse_SaveFalse();
            }
            else
            {
                Logging.SpecificLog("SubTrue", "DownloadStates");
                SubPathsTrue_SaveFalse();
            }
        }
        private void SubPathsTrue_SaveFalse()
        {
            Logging.SpecificLog("SubPathsTrue_SaveFalse", "DownloadStates");
            // IF no Select download Patch
            CommonOpenFileDialog folderDlg = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };
            if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // Set download Patch
                var Selected = $"{folderDlg.FileName}\\{SubFolder}";
                INI.Set_tempdownloaded(Selected);
                Logging.SpecificLog(CompOrNormal + " | " + Selected, "DownloadStates");
                if (CompOrNormal == "Compressed")
                {
                    CompDown();
                }
                if (CompOrNormal == "Normal")
                {
                    NormDown();
                }
            }
            else
            {
                Logging.WriteLog("Folder Selection cancelled");
            }
        }
        private void SubPathsFalse_SaveFalse()
        {
            Logging.SpecificLog("SubPathsFalse_SaveFalse", "DownloadStates");
            // IF no Select download Patch
            CommonOpenFileDialog folderDlg = new CommonOpenFileDialog
            { IsFolderPicker = true };
            if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // Set download Patch
                var Selected = folderDlg.FileName;
                INI.Set_tempdownloaded(Selected);
                Logging.SpecificLog(CompOrNormal + " | " + Selected, "DownloadStates");
                if (CompOrNormal == "Compressed")
                {
                    CompDown();
                }
                if (CompOrNormal == "Normal")
                {
                    NormDown();
                }
            }
            else
            {
                Logging.WriteLog("Folder Selection cancelled");
            }
        }
        private void SubPathsFalse_SaveTrue()
        {
            Logging.SpecificLog("SubPathsFalse_SaveTrue", "DownloadStates");
            if (string.IsNullOrEmpty(ini.GetFolder()))
            {
                CommonOpenFileDialog folderDlg = new CommonOpenFileDialog
                { IsFolderPicker = true };
                if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var Selected = folderDlg.FileName;
                    // Set download Patch
                    INI.SetFolder(Selected);
                    INI.Set_tempdownloaded(Selected);
                    Logging.SpecificLog(CompOrNormal + " | " + Selected, "DownloadStates");
                    if (CompOrNormal == "Compressed")
                    {
                        CompDown();
                    }
                    if (CompOrNormal == "Normal")
                    {
                        NormDown();
                    }
                }
                else
                {
                    Logging.WriteLog("Folder Selection cancelled");
                }
            }
            else
            {
                INI.Set_tempdownloaded(ini.GetFolder());
                Logging.SpecificLog(CompOrNormal, "DownloadStates");
                if (CompOrNormal == "Compressed")
                {
                    CompDown();
                }
                if (CompOrNormal == "Normal")
                {
                    NormDown();
                }
            }
        }
        private void SubPathsTrue_SaveTrue()
        {
            Logging.SpecificLog("SubPathsTrue_SaveTrue", "DownloadStates");
            if (string.IsNullOrEmpty(ini.GetFolder()))
            {

                CommonOpenFileDialog folderDlg = new CommonOpenFileDialog
                { IsFolderPicker = true };
                if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    // Set download Patch
                    var Selected = $"{folderDlg.FileName}\\{SubFolder}";
                    INI.SetFolder(folderDlg.FileName);
                    INI.Set_tempdownloaded(Selected);
                    Logging.SpecificLog(CompOrNormal + " | " + Selected, "DownloadStates");
                    if (CompOrNormal == "Compressed")
                    {
                        CompDown();
                    }
                    if (CompOrNormal == "Normal")
                    {
                        NormDown();
                    }
                }
                else
                {
                    Logging.WriteLog("Folder Selection cancelled");
                }
            }
            else
            {
                var select = ini.GetFolder() + "\\" + SubFolder;
                INI.Set_tempdownloaded(select);
                Logging.SpecificLog(CompOrNormal + " | " + select, "DownloadStates");
                if (CompOrNormal == "Compressed")
                {
                    CompDown();
                }
                if (CompOrNormal == "Normal")
                {
                    NormDown();
                }
            }
        }
        #endregion
        #region Actual Downloading
        private void DownloadStart()
        {
            // Check name is null or empty
            if (string.IsNullOrEmpty(dw.GetName()) || string.IsNullOrEmpty(dw.GetManifestContent()))
            {
                // IF yes Mbox pop up
                AltUI.Forms.DarkMessageBox.ShowMessage("Please enter a username \nOr select season!", "Error");
                Logging.WriteLog("Username or Season not selected");
            }
            else
            {
                if (ini.GetSavePath() == false)
                {
                    Logging.SpecificLog("SaveFalse", "DownloadStates");
                    SavePathFalse();
                }
                else
                {
                    Logging.SpecificLog("SaveTrue", "DownloadStates");
                    SavePathTrue();
                }
            }
        }
        public void CompDown()
        {
            Logging.WriteLog("Compressed Download Started");
            Logging.PathTXT(ini.Get_tempdownloaded());
            INI.SetInstalledSeason_Path(SDKName, ini.Get_tempdownloaded());
            INI.SetInstalledSeason_I(SDKName);
            Download.Downloading(3);
        }
        public void NormDown()
        {
            Logging.WriteLog("Download Started");
            Logging.PathTXT(ini.Get_tempdownloaded());
            INI.SetInstalledSeason_Path(SDKName, ini.Get_tempdownloaded());
            INI.SetInstalledSeason_I(SDKName);
            Download.Downloading(2);
        }
        #endregion
    }
}
