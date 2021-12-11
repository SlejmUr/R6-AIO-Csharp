using AIO_Tools.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class StartingGame : Form
    {
        #region Starting and LoadForm
        //make prive things
        private string STARTEXE;
        private string Path;
        private bool NeedBE_Off;
        private INI ini = new INI();
        private static readonly string datasdb = Utils.datasDB;
        private List<string> InstalledSeaons = new List<string>();

        public StartingGame()
        {
            InitializeComponent();
        }
        private void StartGame_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("StartingGame Loaded");
            FILLName();
        }
        #endregion
        #region SQL
        private void FILLName()
        {
            InstalledBox.Items.Clear();
            InstalledSeaons.Clear();
            string pickgetnet;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT pickgetnet FROM pick GROUP BY pick.pickgetnet ORDER BY pick.pickfoldername ASC";
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    pickgetnet = rdr["pickgetnet"].ToString();
                    InstalledBox.Items.Add(pickgetnet);
                    IsInstalled(pickgetnet);
                }
            }
        }
        #endregion
        #region X Changed
        private void InstalledBox_IndexChanged(object sender, EventArgs e)
        {

            int indx = InstalledBox.SelectedIndex;
            if (indx == -1) { return; }
            string season = InstalledSeaons[indx].ToString();
            Path = ini.GetInstalledSeason_Path(season);
            PathLabel.Text = Path;
            Checking();
            if (!string.IsNullOrEmpty(STARTEXE)) {ResponseLabel.Text = "StartExe Found: " + STARTEXE;}
        }
        private void VulkanCheckBox_Changed(object sender, EventArgs e)
        {
            Checking();
            if (!string.IsNullOrEmpty(STARTEXE)) { ResponseLabel.Text = "StartExe Found: " + STARTEXE; }
        }
        #endregion
        #region Clicked
        private void StartButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(STARTEXE))
            {
                MBoxDef msgb = new MBoxDef();
                msgb.Size = new Size(200, 100);
                msgb.UpdateLabel("Starting " + STARTEXE + " !\nWith BattlEye off? " + NeedBE_Off);
                msgb.UpdateButton(130, 65);
                msgb.ShowDialog();
                Process process = new Process();
                process.StartInfo.FileName = Path + "\\" + STARTEXE;
                if (NeedBE_Off == true) { process.StartInfo.Arguments = " /belaunch"; }
                process.Start();
                Logging.SpecificLog(STARTEXE + " Belaunch? " + NeedBE_Off + " Started!", "StartGame");
            }
        }
        private void KillButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(STARTEXE))
            {
                string processnotexe = STARTEXE.Replace(".exe", "");
                Process[] process = Process.GetProcesses();
                for (int i = 0; i < process.Length; i++)
                {
                    Logging.DebugLog(process[i].ProcessName, "KillProcess");
                    if (process[i].ProcessName == processnotexe)
                    {
                        process[i].Kill();
                        Logging.SpecificLog(process[i].ProcessName + " got Killed", "StartGame");
                    }
                }
            }
        }
        private void RemovePaths_Clicked(object sender, EventArgs e)
        {
            int indx = InstalledBox.SelectedIndex;
            if (indx == -1) { return; }
            string season = InstalledSeaons[indx].ToString();
            INI.RemoveInstalledSeason_Path(season);
            INI.RemoveInstalledSeason_I(season);
            ResponseLabel.Text = season + " Got Removed from INI/StartingGame";
            FILLName();
        }
        private void DeleteAll_Clicked(object sender, EventArgs e)
        {
            ChooseBox chooseBox = new ChooseBox();
            chooseBox.UpdateAll("Are you sure you want to delete from ini and the GAME too?", "No", "Yes");
            chooseBox.ShowDialog();
            string Choosed = chooseBox.GetChoosed();
            if (Choosed == "1")
            {
                ResponseLabel.Text = "Delete Cancelled";
                return;
            }
            if (Choosed == "2")
            {
                ResponseLabel.Text = "Delete Started";
                int items = InstalledBox.Items.Count;
                for (int i = 0; i < items; i++)
                {
                    string season = InstalledSeaons[i].ToString();
                    string dir_path = ini.GetInstalledSeason_Path(season);
                    INI.RemoveInstalledSeason_Path(season);
                    INI.RemoveInstalledSeason_I(season);
                    if (Directory.Exists(dir_path))
                    {
                        Directory.Delete(dir_path);
                        Logging.WriteLog(dir_path + " will/(was) be deleted");
                    }
                    ResponseLabel.Text = season + " Got Removed from INI/StartingGame";
                }
                ResponseLabel.Text = "All Season Got Removed from INI/StartingGame!";
                InstalledBox.Items.Clear();
                InstalledSeaons.Clear();
                STARTEXE = null;
                Logging.WriteLog("All Season Got Removed from INI/StartingGame");
            }
        }
        #endregion
        #region Voids (Checking, IsInstalled)
        private void Checking()
        {
            NeedBE_Off = true;
            if (File.Exists(Path + "\\RainbowSixGame.exe")) //Checking old RainbowSixGame.exe
            {
                STARTEXE = "RainbowSixGame.exe";
                return;
            }
            if (File.Exists(Path + "\\LumaPlay_x64.exe")) //Checking LumaPlay_x64.exe
            {
                STARTEXE = "LumaPlay_x64.exe";
                NeedBE_Off = false;
                return;
            }
            if (CheckBox_Vulkan.Checked == true)
            {
                if (File.Exists(Path + "\\RainbowSix_Vulkan.exe")) //Checking RainbowSix_Vulkan.exe
                {
                    STARTEXE = "RainbowSix_Vulkan.exe";
                }
            }
            else
            {
                if (File.Exists(Path + "\\RainbowSix_BE.exe")) //Checking RainbowSix_BE.exe
                {
                    STARTEXE = "RainbowSix.exe";
                }
                if (File.Exists(Path + "\\RainbowSix.exe")) //Checking RainbowSix.exe
                {
                    STARTEXE = "RainbowSix.exe";
                }
            }
        }
        private void IsInstalled(string SeasonName)
        {
            string installed = ini.GetInstalledSeason_I(SeasonName);
            if (string.IsNullOrEmpty(installed))
            {
                InstalledBox.Items.Remove(SeasonName);
            }
            if (installed == "Installed")
            {
                int indx = InstalledBox.Items.IndexOf(SeasonName);
                InstalledBox.Items.Insert(indx, SeasonName + " Installed!");
                InstalledBox.Items.RemoveAt(indx + 1);
                InstalledSeaons.Add(SeasonName);
            }
        }
        #endregion
    }
}
