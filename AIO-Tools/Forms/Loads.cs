using AIO_Tools.Classes;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class Loads : Form
    {
        #region LoadAllPictures
        //Need this to be "Faster?" on the MainMenu
        public Loads()
        {
            InitializeComponent();

        }
        private Utils utils = new Utils();
        private void LoadPicktures()
        {
            foreach (string i in utils.picturesNames)
            {
                button1.BackgroundImage = GettingNet.SetIMG(i);
            }
        }
        private void FromLoad(object sender, System.EventArgs e)
        {
            LoadPicktures();
            Close();
        }
        #endregion
    }
}
