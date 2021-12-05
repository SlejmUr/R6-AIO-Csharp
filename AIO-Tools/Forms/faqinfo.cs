using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools
{
    public partial class faqinfo : Form
    {
        #region Literally nothing usefull
        public faqinfo()
        {
            InitializeComponent();
        }

        private void ReturnButton(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
        private void faqinfo_Load(object sender, EventArgs e)
        {
            UI_MODE();
        }

        public void UI_MODE()
        {
            Classes.INI ini = new Classes.INI();
            if (ini.GetUI_MODE() == true)
            {
                //faqinfo
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                Logging.SpecificLog("faqinfo Turned ON", "UI_Mode");
            }
            else
            {
                //Logging.SpecificLog("faqinfo Turned OFF", "UI_Mode");
            }
        }
        #endregion
    }
}
