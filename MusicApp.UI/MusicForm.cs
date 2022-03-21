
using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using MusicApp.UI.User_Controls;
using System;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class MusicForm : Form
    {
        public MusicForm()
        {
            InitializeComponent();

            LoginUC.LoginSucceedEvent += (um, u) =>
            {
                UserManager = um;
                UserConnected = u;
                panel1.Controls.Clear();
                panel1.Controls.Add(new StartPageUC(u));
            };

            LoginUC.SingInEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new SignInUC());
            };

            LoginUC.ForgotPasswardEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new ForgotPasswardUC());
            };

            StartPageUC.EditArtistEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new EditArtistsUC());
            };


            StartPageUC.EditSongsEvent += () =>
            {


                panel1.Controls.Clear();
                panel1.Controls.Add(new EditSongUC());
            };

            StartPageUC.EditUsersEvent += () =>
            {


                panel1.Controls.Clear();
                panel1.Controls.Add(new EditUsersUC());
            };

            StartPageUC.DisconectEvent += () =>
            {

                UserManager = null;
                UserConnected = null;
                panel1.Controls.Clear();
                panel1.Controls.Add(new LoginUC());
            };


            EditArtistsUC.HomeButtonPressedEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new StartPageUC());
            };
            EditSongUC.HomeButtonPressedEvent += u =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new StartPageUC(u));
            };
            EditUsersUC.HomeButtonPressedEvent += u =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new StartPageUC(u));
            };

            UsersRepository.NewUserAddedEvent += u =>
            {
                UserConnected = u;
                UserManager = new SimpleUserProxie();
                panel1.Controls.Clear();
                panel1.Controls.Add(new StartPageUC(UserConnected));
            };
            AlbumRepository.MessegeEvent += m => MessageBox.Show(m);
            GenreRepository.MessegeEvent += m => MessageBox.Show(m);
            SongRepository.MessegeEvent += m => MessageBox.Show(m);

            SignInUC.BackButtonPressedEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new LoginUC());
            };
            ForgotPasswardUC.BackButtonPressedEvent += () =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new LoginUC());
            };
            ForgotPasswardUC.SingInEvent += email =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new SignInUC(email));
            };
        }




        public static IAmUser UserManager;
        public static User UserConnected;

        private void MusicForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new LoginUC());
        }



    }
}
