using System;

namespace AIO_Tools.Forms
{
    public partial class Notes : AltUI.Forms.DarkForm
    {
        #region Load and functions
        public Notes()
        {
            InitializeComponent();
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
        private void Notes_Load(object sender, EventArgs e)
        {
            Logging.WriteLog("Notes Loaded");
        }
        #endregion
    }
}
