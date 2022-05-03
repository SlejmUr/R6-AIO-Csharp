using System;
using System.Windows.Forms;

namespace AIO_Tools.Forms
{
    public partial class ChooseBox : AltUI.Forms.DarkForm
    {
        public ChooseBox()
        {
            InitializeComponent();
        }

        private string Choosed = "";
        public string GetChoosed()
        {
            return Choosed;
        }
        private void SetChoosed(string NewChoosed)
        {
            Choosed = NewChoosed;
        }
        public void UpdateAll(string LabelText, string Button1Text, string Button2Text)
        {
            Label_Info.Text = LabelText;
            Choose1_Button.Text = Button1Text;
            Choose2_Button.Text = Button2Text;
        }

        private void Choose1_Clicked(object sender, EventArgs e)
        {
            SetChoosed("1");
            Choosed = "1";
        }

        private void Choose2_Clicked(object sender, EventArgs e)
        {
            SetChoosed("2");
            Choosed = "2";
        }
        private void Continue_Clicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
