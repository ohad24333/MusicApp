using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class SignInUC : UserControl
    {
        public SignInUC()
        {
            InitializeComponent();

            AppManagement.MessegeEvent += m => MessageBox.Show(m);
        }
        public SignInUC(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
            AppManagement.MessegeEvent += m => MessageBox.Show(m);
        }

        public static event Action BackButtonPressedEvent;

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ISignIn signIn = new SignInProxy();
            User newUser = new User()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            signIn.CheckSignInCollumnsValidilty(newUser);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonPressedEvent();
        }
    }
}
