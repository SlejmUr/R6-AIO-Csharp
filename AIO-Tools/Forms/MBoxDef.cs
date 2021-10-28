using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools
{
    public partial class MBoxDef : Form
    {
        #region Load
        public MBoxDef()
        {
            InitializeComponent();
        }
        private void MBoxDef_Load(object sender, EventArgs e)
        {
            UI_MODE();
        }
        public void UI_MODE()
        {
            Classes.INI ini = new Classes.INI();
            if (ini.GetUI_MODE() == true)
            {
                //MBoxDef
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                OK_Button.ForeColor = Color.Black;
                LabelText.ForeColor = Color.Black;
                Logging.SpecificLog("MBoxDef Turned ON", "UI_Mode");
            }
            else
            {
                //Logging.SpecificLog("MBoxDef Turned OFF", "UI_Mode");
            }
        }
        #endregion
        #region Functions
        public void UpdateLabel(string str)
        {
            LabelText.Text = str;
        }
        public void UpdateButton(int first, int second)
        {
            OK_Button.Location = new Point(first, second);
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion
    }
}
