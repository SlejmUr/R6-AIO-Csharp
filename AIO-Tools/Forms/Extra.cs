using AIO_Tools.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Extra : AltUI.Forms.DarkForm
    {
        #region Load
        public Extra()
        {
            InitializeComponent();
        }

        private string lang_select;
        private string DepotID;
        private string ManifestID;
        private string AppID;
        private static readonly string datasdb = Utils.datasDB;

        private void Extra_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("Extra Loaded");
            GettingNet.DB_Download();
        }
        #endregion
        #region SQL
        private void FILLYear(string Glang)
        {
            comboBox2.Items.Clear();
            string pickyear;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT pickyear FROM ultimateDepot, pick WHERE ultimateDepot.depotdate = pick.pickdate AND ultimateDepot.depotname LIKE @lang AND upper(ultimateDepot.manifest) != \"X\" GROUP BY pick.pickyear";
            cmd.Parameters.AddWithValue("@lang", Glang);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    pickyear = rdr["pickyear"].ToString();
                    comboBox2.Items.Add(pickyear);
                }
            }
        }

        private void FILLPick(string GYear)
        {
            comboBox3.Items.Clear();
            string pickname;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT pickname FROM ultimateDepot, pick WHERE ultimateDepot.depotdate = pick.pickdate AND pick.pickyear LIKE @year AND upper(ultimateDepot.manifest) != \"X\" AND ultimateDepot.depotname LIKE @depotname GROUP BY pick.pickname ORDER BY pick.pickname ASC";
            cmd.Parameters.AddWithValue("@year", GYear);
            cmd.Parameters.AddWithValue("@depotname", lang_select);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    pickname = rdr["pickname"].ToString();
                    comboBox3.Items.Add(pickname);
                }
            }
        }

        private void SeasonSelect_Change(object sender, EventArgs e)
        {
            //Get Manifest/Depot from database
            var pick = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT manifest,depotid,appid FROM ultimateDepot, pick WHERE ultimateDepot.depotdate = pick.pickdate AND ultimateDepot.depotname LIKE @lang AND pick.pickname LIKE @name";
            cmd.Parameters.AddWithValue("@lang", lang_select);
            cmd.Parameters.AddWithValue("@name", pick);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            ManifestID = rdr["manifest"].ToString();
            DepotID = rdr["depotid"].ToString();
            AppID = rdr["appid"].ToString();
        }
        #endregion
        #region Buttons
        private void Year_Changed(object sender, EventArgs e)
        {
            //Clear Comboboxes
            comboBox3.Items.Clear();
            comboBox3.ResetText();
            //Fill the pick with selected year
            var year = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            FILLPick(year);
        }

        private void ExtraLang_Changed(object sender, EventArgs e)
        {
            //Clear Comboboxes
            comboBox2.Items.Clear();
            comboBox2.ResetText();
            comboBox3.Items.Clear();
            comboBox3.ResetText();
            //Fill the year with selected lang
            var lang = this.ExtraLang.GetItemText(this.ExtraLang.SelectedItem);
            FILLYear(lang);
            lang_select = lang;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DownloadNow_Click(object sender, EventArgs e)
        {
            if (DepotID != null & ManifestID != null)
            {
                Download dw = new Download();
                dw.SetDepotContent(DepotID);
                dw.SetManifestContent(ManifestID);
                dw.SetAppID(AppID);

                if (dw.GetName() == null & string.IsNullOrEmpty(dw.GetName()))
                {
                    AltUI.Forms.DarkMessageBox.ShowMessage("Please enter a username", "Error");
                }
                else
                {
                    // IF no Select download Path
                    CommonOpenFileDialog folderDlg = new CommonOpenFileDialog();
                    folderDlg.IsFolderPicker = true;
                    if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        // Set download Patch
                        Logging.PathTXT(folderDlg.FileName);
                    }
                    Download.Downloading(1);
                }
            }
            else
            {
                AltUI.Forms.DarkMessageBox.ShowMessage("Please choose all items!", "Error");
            }
        }
        #endregion
    }
}
