using MusicApp.Entities.Models;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class EditSongMiniUC : UserControl
    {
        public EditSongMiniUC(Song song)
        {
            InitializeComponent();
            CurrentSelectedSong = song;
        }


       
        public Song CurrentSelectedSong { get; set; }

        private void EditSongMiniUC_Load(object sender, EventArgs e)
        {
            dtpDuration.CustomFormat = "hh:mm";
            dtpDuration.ShowUpDown = true;



            var genres = MusicForm.UserManager.GetAllGenresList();
            var publishers = MusicForm.UserManager.GetAllPublishersList();
            var albums = MusicForm.UserManager.GetAlbumList(MusicForm.UserManager.SearchArtist(CurrentSelectedSong.ArtistId));

            int tempIdForSelectedIndex = 0;
            foreach (var genre in genres)
            {
                comboxGenre.Items.Add(genre.Name);
                
                if (genre.Id == CurrentSelectedSong.GenreId)
                {
                    tempIdForSelectedIndex = comboxGenre.Items.Count -1;
                }
            }
         
            comboxGenre.SelectedIndex = tempIdForSelectedIndex;


            foreach (var item in publishers)
            {
                comboxPublisher.Items.Add(item.CompanyName);
                if (item.Id == CurrentSelectedSong.PublisherId)
                {
                    tempIdForSelectedIndex = comboxPublisher.Items.Count - 1;
                }
            }
            comboxPublisher.SelectedIndex = tempIdForSelectedIndex;

            foreach (var item in albums)
            {
                comboxAlbum.Items.Add(item.AlbumName);
                if (item.Id == CurrentSelectedSong.AlbumId)
                {
                    tempIdForSelectedIndex = comboxAlbum.Items.Count - 1;
                }
            }
            comboxAlbum.SelectedIndex = tempIdForSelectedIndex;

            txtSongName.Text = CurrentSelectedSong.Name;
            dtpDatePublished.Value = CurrentSelectedSong.DatePublished;
            dtpDatePublished.Value = CurrentSelectedSong.Duration;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentSelectedSong.Name = txtSongName.Text;
            CurrentSelectedSong.DatePublished = dtpDatePublished.Value;
            CurrentSelectedSong.Duration = dtpDuration.Value;
            CurrentSelectedSong.GenreId = MusicForm.UserManager.GetGenre(comboxGenre.Text).Id;
            CurrentSelectedSong.PublisherId = MusicForm.UserManager.GetPublisher(comboxPublisher.Text).Id;
            CurrentSelectedSong.AlbumId = MusicForm.UserManager.GetAlbum(comboxAlbum.Text).Id;

            

            MusicForm.UserManager.UpdateToDataBase(CurrentSelectedSong);
           
        }
    }
}
