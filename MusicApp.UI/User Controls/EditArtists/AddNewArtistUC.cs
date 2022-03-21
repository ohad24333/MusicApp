using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls.EditArtists
{
    public partial class AddNewArtistUC : UserControl
    {
        public List<Coutry> Coutries { get; set; }
        public EditArtistsUC  EditArtistsUC {get;set;}
        public AddNewArtistUC(EditArtistsUC editArtistsUC)
        {
            InitializeComponent();
            EditArtistsUC = editArtistsUC;

        }

        private void AddNewArtistUC_Load(object sender, EventArgs e)
        {
            Coutries = MusicForm.UserManager.GetAllCountries();
            foreach (var item in Coutries)
            {
                comboxContries.Items.Add(item.Name);
            }
            comboxContries.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Artist newArtist = new Artist()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                StageName = txtStageName.Text,
                CoutryId = Coutries.Find(c => c.Name == comboxContries.Text).Id,
                Albums = new List<Album>() { new Album() { AlbumName = "Singles" , DatePublished = DateTime.Now}}
                
            };

            MusicForm.UserManager.AddToDataBase(newArtist);
            EditArtistsUC.Artists.Add(newArtist);
           
        }
    }
}
