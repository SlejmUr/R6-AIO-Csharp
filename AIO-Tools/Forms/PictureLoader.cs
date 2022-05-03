using AIO_Tools.Classes;

namespace AIO_Tools.Forms
{
    public partial class PictureLoader : AltUI.Forms.DarkForm
    {
        #region LoadAllPictures
        //Need this to be "Faster?" on the MainMenu
        public PictureLoader()
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
