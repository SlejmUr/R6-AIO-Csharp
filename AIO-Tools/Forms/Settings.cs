using AIO_Tools.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Settings : Form
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
            INI.SetUserName(TextName);
        }
        private void Validate_Name()
        {
            //Set the name
            dw.SetName(NameBox.Text);
            TextName = NameBox.Text;
            INI.SetUserName(TextName);
            Logging.WriteLog(String.Format("Username validated as [{0}]", NameBox.Text));
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Validate_Name();
        }
        private void ValidateName(object sender, EventArgs e)
        {
            Validate_Name();
            //Mbox pop up
            using MBoxDef msgb = new MBoxDef();
            msgb.Size = new Size(203, 104);
            msgb.UpdateLabel("Username Validated");
            msgb.UpdateButton(126, 43);
            msgb.Show();
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
        #region UI and loads
        private void Settings_Load(object sender, EventArgs e)
        {
            UI_MODE();
            CheckFile();
        }
        private void UI_MODE()
        {
            if (ini.GetUI_MODE() == true)
            {
                //MainMenu
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                SteamName_Label.ForeColor = Color.Black;
                SetUserName.ForeColor = Color.Black;
                Compressed_INFO.ForeColor = Color.Black;
                StreamingInstall_Button.ForeColor = Color.Black;
                faqButton.ForeColor = Color.Black;
                ExtraButton.ForeColor = Color.Black;
                NotesButton.ForeColor = Color.Black;
                PlazaGet_Button.ForeColor = Color.Black;
                NameBox.BackColor = Color.White;
                NameBox.ForeColor = Color.Black;
                All_Manifest.ForeColor = Color.Black;
                Logging.SpecificLog("MainMenu Turned ON", "UI_Mode");
            }
        }
        #endregion
    }
}