using MusicApp.Entities.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class EditUserMiniUC : UserControl
    {
        public User CurrentSelectedUser { get; set; }

        public EditUserMiniUC(User user)
        {
            InitializeComponent();
            CurrentSelectedUser = user;
        }

        private void EditUserMiniUC_Load(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            txtFirstName.Text = CurrentSelectedUser.FirstName;
            txtLastName.Text = CurrentSelectedUser.LastName;
            txtEmail.Text = CurrentSelectedUser.Email;
            txtPassword.Text = CurrentSelectedUser.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationMassege = CheckInsertValidility();
            if (validationMassege == null)
            {
                CurrentSelectedUser.FirstName = txtFirstName.Text;
                CurrentSelectedUser.LastName = txtLastName.Text;
                CurrentSelectedUser.Email = txtEmail.Text;
                CurrentSelectedUser.Password = txtPassword.Text;

                MusicForm.UserManager.UpdateToDataBase(CurrentSelectedUser);
            }
            else
            {
                MessageBox.Show(validationMassege);
            }
         
        }

        private string CheckInsertValidility()
        {
            var nameRegex = new Regex(@"[A-z]{2,10}", RegexOptions.IgnoreCase);
            var emailRegex = new Regex(@"^[A-z]{3,10}[\w]{0,10}(\@gmail|\@yahoo|@walla)\.(net|com)", RegexOptions.IgnoreCase);
            if (!nameRegex.IsMatch(txtFirstName.Text))
            {
                return "First Name Invalide";
            }
            if (!nameRegex.IsMatch(txtLastName.Text))
            {
                return "Last Name Invalide";
            }
            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                return "Email is Invalide";
            }
            return null;
        }
    }
}
