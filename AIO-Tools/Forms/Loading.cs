using AIO_Tools.Classes;
using System;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        #region Start Timing and close
        readonly Timer formClose = new Timer();
        private void Loaded(object sender, EventArgs e)
        {
            formClose.Interval = 2000;
            formClose.Tick += new EventHandler(FullyLoaded);
            formClose.Start();
        }
        public void FullyLoaded(object sender, EventArgs e)
        {
            formClose.Stop();
            formClose.Tick -= new EventHandler(FullyLoaded);
            VersionCheck();
            GettingNet.Starting();
            this.Close();
        }

        private void VersionCheck()
        {
            string tmpVersion = Utils.Version;
            string webVersion = GettingNet.GetVersion();
            if (tmpVersion != webVersion)
            {
                Logging.SpecificLog("Version Missmatch! [Tool Version:" + tmpVersion +  " , Web Version: " + webVersion +  " ]", "Loading/Starting");
            }
        }
        #endregion
    }
}
