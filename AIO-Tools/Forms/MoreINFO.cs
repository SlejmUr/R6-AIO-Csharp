using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class MoreINFO : Form
    {
        #region Load and functions
        public MoreINFO()
        {
            InitializeComponent();
        }

        private void ReturnButton(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        public void UI_MODE()
        {
            Classes.INI ini = new Classes.INI();
            if (ini.GetUI_MODE() == true)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                BackToMain.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                Logging.SpecificLog("MoreINFO Turned ON", "UI_Mode");
            }
            else
            {
                //Logging.SpecificLog("MoreINFO Turned OFF", "UI_Mode");
            }
        }

        private void CompINFO_Load(object sender, EventArgs e)
        {
            UI_MODE();
        }
        #endregion
    }
}
