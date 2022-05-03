﻿using AIO_Tools.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Loading : AltUI.Forms.DarkForm
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
            GettingNet.Starting();
            VersionCheck();
            this.Close();
        }

        private void VersionCheck()
        {
            string tmpVersion = Utils.Version;
            string webVersion = GettingNet.GetVersion();
            if (tmpVersion.StartsWith("DEV-"))
            {
                Logging.DebugLog("DEV version! No support, only for testing", "Loading/Starting");
            }
            else
            {
                if (tmpVersion != webVersion)
                {
                    Logging.SpecificLog("Version Missmatch! [Tool Version:" + tmpVersion + " , Web Version: " + webVersion + " ]", "Loading/Starting");
                    GettingNet.Update_Download();
                    // Mbox pop up
                    AltUI.Forms.DarkMessageBox.ShowMessage("Version Missmatch\nPlease start AIO-Updater.bat!", "Error");
                }
            }
        }
        #endregion
    }
}
