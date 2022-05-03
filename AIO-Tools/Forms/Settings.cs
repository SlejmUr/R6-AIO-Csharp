using AIO_Tools.Classes;
using System;

namespace AIO_Tools.Forms
{
    public partial class Settings : AltUI.Forms.DarkForm
    {
        #region Starts
        private string TextName;
        // Private things for easier use
        private Download dw = new Download();
        private INI ini = new INI();
        public Settings()
        {
            InitializeComponent();
        }
        #endregion
        #region NameCheck and Validate
        public void CheckFile()
        {
            TextName = ini.GetUserName();
            NameBox.Text = TextName;
            dw.SetName(TextName);
        }
        private void Validate_Name()
        {
            //Set the name
            TextName = NameBox.Text;
            dw.SetName(TextName);
            INI.SetUserName(TextName);
            Logging.WriteLog(String.Format("Username validated as [{0}]", TextName));
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Validate_Name();
        }
        private void ValidateName(object sender, EventArgs e)
        {
            Validate_Name();
            //Mbox pop up
            AltUI.Forms.DarkMessageBox.ShowMessage("Username Validated", "Success");
        }
        #endregion
        #region Move forms, or show forms
        private void MoveCompInfo(object sender, EventArgs e)
        {
            MoreINFO CompINFO = new MoreINFO();
            CompINFO.Show();
        }
        private void MoveNotes(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Show();
        }
        private void MoveExtra(object sender, EventArgs e)
        {
            Extra Extra = new Extra();
            Extra.Show();
        }
        private void All_Manifest_Click(object sender, EventArgs e)
        {
            allmanifest allmanifest = new allmanifest();
            allmanifest.Show();
        }
        private void FAQ_Click(object sender, EventArgs e)
        {
            faqinfo faqinfo = new faqinfo();
            faqinfo.Show();
        }
        #endregion
        #region Getting stuff with GettingNet
        private void Down_Crack(object sender, EventArgs e)
        {
            GettingNet.PlazaDownload();
        }
        private void DownStreaming_Click(object sender, EventArgs e)
        {
            GettingNet.StreamingInstallDownload();
        }
        private void CheckedFast(object sender, EventArgs e)
        {
            GettingNet.DLFast_Check(CheckBox_Fast.Checked);
        }
        #endregion
        #region Loads
        private void Settings_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("Settings Loaded");
            CheckFile();
        }
        #endregion
    }
}
