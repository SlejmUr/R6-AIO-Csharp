using System;

namespace AIO_Tools
{
    public partial class faqinfo : AltUI.Forms.DarkForm
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
            Logging.WriteLog("FaqInfo Loaded");
        }
        #endregion
    }
}
