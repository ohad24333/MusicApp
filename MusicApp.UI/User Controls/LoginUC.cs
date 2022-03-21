using System;
using System.Windows.Forms;
using MusicApp.BusinessLogic;
using MusicApp.Entities;
using MusicApp.Entities.Models;

namespace MusicApp.UI
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
           
        }

        public static event Action<IAmUser, User> LoginSucceedEvent;
        public static event Action SingInEvent;
        public static event Action ForgotPasswardEvent;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            IBeforeLogin beforeLogin = new BeforeLoginProxie();
            User user = beforeLogin.SearchUser(email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    UserPermissionLevelEnum userPermissionLevel = beforeLogin.CheckUserPermissionLevel(user);
                    switch (userPermissionLevel)
                    {
                        case UserPermissionLevelEnum.Admin:
                            LoginSucceedEvent(new AppManagement(), user);
                            break;
                        case UserPermissionLevelEnum.SimpleUser:                          
                            LoginSucceedEvent(new SimpleUserProxie(), user);
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Wrong Password ");
                    return;
                }
            }
            else MessageBox.Show("User Didnt Found");
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            SingInEvent();
        }

        private void btnForOhad_Click(object sender, EventArgs e)
        {
            LoginSucceedEvent(new AppManagement(), new User() { Id =1});
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswardEvent();
        }
    }
}
