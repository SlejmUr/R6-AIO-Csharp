using System;
using System.Windows.Forms;

namespace AIO_Tools
{
    static class Program
    {
        #region Main
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Start The Main Menu (form)
            Logging.WriteLog("AIO Tool Started");
            Application.Run(new Forms.Loading());
            Application.Run(new Forms.Loads());
            Application.Run(new MainMenu());
            Logging.WriteLog("AIO Tool Exited");

        }
        #endregion
    }
}
