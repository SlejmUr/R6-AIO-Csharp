using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools
{
    public partial class MBoxDef : Form
    {
        #region Functions
        public MBoxDef()
        {
            InitializeComponent();
        }
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
