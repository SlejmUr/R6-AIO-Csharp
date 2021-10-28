using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Notes : Form
    {
        #region Load and functions
        public Notes()
        {
            InitializeComponent();
        }
        private void Secret_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well done! Remember: The Aperture Science Bring Your Daughter to Work Day is the perfect time to have her tested.");
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            UI_MODE();
        }

        public void UI_MODE()
        {
            Classes.INI ini = new Classes.INI();
            if (ini.GetUI_MODE() == true)
            {
                //Notes
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                OK_Button.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                Logging.SpecificLog("Notes Turned ON", "UI_Mode");
            }
            else
            {
                //Logging.SpecificLog("Notes Turned OFF", "UI_Mode");
            }
        }
        #endregion
    }
}
