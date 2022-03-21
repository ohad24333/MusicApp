using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class EditUsersUC : UserControl
    {
        public List<User> Users { get; set; } = new List<User>();

        public static Action<User> HomeButtonPressedEvent;
        public User CurrentSelectedUser { get; set; }
        public EditUsersUC()
        {
            InitializeComponent();



            ListItemUC3.BannerClickEvent3 += (email) =>
            {

                OnBannerClick(email);

            };

            UsersRepository.UserUpdatedEvent += u =>
            {
                flowLayoutPanel1.Controls.Clear();


                txtFirstName.Text = u.FirstName;
                txtLastName.Text = u.LastName;
                panelEditArtist.Visible = true;
                ShowUserOnPannel(u);
            };
        }

        private void EditUsersUC_Load(object sender, EventArgs e)
        {
            comboxSearchBy.Items.AddRange(new string[] { "Id", "Name" });
            comboxSearchBy.SelectedIndex = 0;
        }


        private void OnBannerClick(string email)
        {
            flowLayoutPanel1.Controls.Clear();

            CurrentSelectedUser = MusicForm.UserManager.SearchUser(email);

            txtFirstName.Text = CurrentSelectedUser.FirstName;
            txtLastName.Text = CurrentSelectedUser.LastName;

            panelEditArtist.Visible = true;
            if (CurrentSelectedUser != null)
            {


                flowLayoutPanel1.Controls.Add(new EditUserMiniUC(CurrentSelectedUser));
            }
        }
        public void ShowUserOnPannel(User user)
        {
            flowLayoutPanel1.Controls.Clear();

            ListItemUC3 Item = new ListItemUC3()
            {
                Title = user.FirstName + " " + user.LastName,
                Info = $"Email : {user.Email} \nId : {user.Id}",
                Email = user.Email,
                IconBackground = Color.Silver,
                Width = flowLayoutPanel1.Width,
                Id = user.Id
            };

            flowLayoutPanel1.Controls.Add(Item);
           


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboxSearchBy.SelectedItem)
            {
                case "Name":
                    Users = MusicForm.UserManager.SearchUsers(u => u.FirstName.ToLower().StartsWith(txtSearchInsert.Text.ToLower()) ||
                   u.LastName.ToLower().StartsWith(txtSearchInsert.Text.ToLower()));


                    break;
                case "Id":
                    Users.Clear();
                    Users = MusicForm.UserManager.SearchUsers(u => u.Id.ToString() == txtSearchInsert.Text);

                    break;
                default:
                    break;
            }
            if (Users.Count == 0)
            {
                MessageBox.Show("User didnt found");
            }
            else
            {
                OnUsersFound(Users);
            }

        }
        public void OnUsersFound(List<User> usersList)
        {
            flowLayoutPanel1.Controls.Clear();
   
            foreach (var user in usersList)
            {
                ListItemUC3 Item = new ListItemUC3()
                {
                    Title = user.FirstName + " " + user.LastName,
                    Info = $"Email : {user.Email} \nId : {user.Id}",
                    Email = user.Email,
                    IconBackground = Color.Silver,
                    Width = flowLayoutPanel1.Width,
                    Id = user.Id
                };

                flowLayoutPanel1.Controls.Add(Item);
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeButtonPressedEvent(MusicForm.UserConnected);
        }
    }
}
