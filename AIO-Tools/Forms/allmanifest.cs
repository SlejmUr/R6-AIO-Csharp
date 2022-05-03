using AIO_Tools.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class allmanifest : AltUI.Forms.DarkForm
    {
        #region Start
        public allmanifest()
        {
            InitializeComponent();
        }
        //making strings
        private string DepotID;
        private string ManifestID;
        private string AppID;
        private string Date;
        //DB integration
        private static readonly string datasdb = Utils.allDB;

        private void AllManifest_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("AllManifest Loaded");
            FILLName();
        }
        #endregion
        #region SQL
        private void FILLName()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string depotname;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT depotname FROM allDepot GROUP BY allDepot.depotname ORDER BY allDepot.depotname ASC";
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    depotname = rdr["depotname"].ToString();
                    comboBox1.Items.Add(depotname);
                }
            }
        }

        private void FILLManifest(string Name)
        {
            comboBox2.Items.Clear();
            string manifest;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT manifest FROM allDepot WHERE allDepot.depotname LIKE @name";
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    manifest = rdr["manifest"].ToString();
                    comboBox2.Items.Add(manifest);
                }
            }
        }

        private void SelectedManifest_Changed(object sender, EventArgs e)
        {
            var pick = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT manifest,depotid,appid,date FROM allDepot WHERE allDepot.manifest LIKE @pick";
            cmd.Parameters.AddWithValue("@pick", pick);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    ManifestID = rdr["manifest"].ToString();
                    DepotID = rdr["depotid"].ToString();
                    AppID = rdr["appid"].ToString();
                    Date = rdr["date"].ToString();
                    //Date set to versionlabel
                    versiondate_label.Text = Date;
                }
            }
        }
        #endregion
        #region Buttons
        private void SelectedName_Changed(object sender, EventArgs e)
        {
            var Name = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            FILLManifest(Name);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Download_Click(object sender, EventArgs e)
        {
            if (DepotID != null & ManifestID != null)
            {
                Download dw = new Download();
                dw.SetDepotContent(DepotID);
                dw.SetManifestContent(ManifestID);
                dw.SetAppID(AppID);

                if (dw.GetName() == null & string.IsNullOrEmpty(dw.GetName()))
                {
                    AltUI.Forms.DarkMessageBox.ShowMessage("Please enter a username on main tool", "Error");
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
                AltUI.Forms.DarkMessageBox.ShowMessage("Please choose All Items!", "Error");
            }
        }
        #endregion
    }
}
