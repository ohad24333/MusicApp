
using MusicApp.Entities.Models;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class AddNewSongUC : UserControl
    {

        public Artist CurrentSelectedArtist { get; set; }
        public AddNewSongUC(Artist artist)
        {
            InitializeComponent();
            CurrentSelectedArtist = artist;

        }

        private void AddNewSongUC_Load(object sender, EventArgs e)
        {
            var genres = MusicForm.UserManager.GetAllGenresList();
            var publishers = MusicForm.UserManager.GetAllPublishersList();
            var albums = MusicForm.UserManager.GetAlbumList(CurrentSelectedArtist);


            foreach (var genre in genres)
            {
                comboxGenre.Items.Add(genre.Name);
            }
            comboxGenre.SelectedIndex = 0;
            foreach (var item in publishers)
            {
                comboxPublisher.Items.Add(item.CompanyName);
            }
            comboxPublisher.SelectedIndex = 0;
            foreach (var item in albums)
            {
                comboxAlbum.Items.Add(item.AlbumName);
            }        
            comboxAlbum.SelectedIndex = 0;   
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Song newSong = new Song()
            {
                Name = txtSongName.Text,
                ArtistId = CurrentSelectedArtist.Id,
                DatePublished = dtpDatePublished.Value,
                Duration  = dtpDuration.Value,
                GenreId = MusicForm.UserManager.GetGenre(comboxGenre.Text).Id,
                PublisherId = MusicForm.UserManager.GetPublisher(comboxPublisher.Text).Id,
                AlbumId = MusicForm.UserManager.GetAlbum(comboxAlbum.Text).Id

            };

            MusicForm.UserManager.AddToDataBase(newSong);
            
        }
    }
}
