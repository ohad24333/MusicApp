using System;
using System.Windows.Forms;
using MusicApp.BusinessLogic;

namespace MusicApp.UI.User_Controls
{
    public partial class ForgotPasswardUC : UserControl
    {
        public ForgotPasswardUC()
        {
            InitializeComponent();
            AppManagement.MessegeEvent += m => MessageBox.Show(m);

        }
        public static event Action BackButtonPressedEvent;
        public static event Action<string> SingInEvent;
        private void lblSendPasswardToMyEmail_Click(object sender, EventArgs e)
        {
            IForgotPassward forgotPassward = new ForgotPasswardProxy();
            forgotPassward.SendEmailWithPassward(txtEmail.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonPressedEvent();
        }

        private void kbkSignIn_Click(object sender, EventArgs e)
        {
            SingInEvent(txtEmail.Text);
        }
    }
}
