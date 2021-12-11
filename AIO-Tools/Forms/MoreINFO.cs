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

        private void CompINFO_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("Compressed Info Loaded");
        }
        #endregion
    }
}
