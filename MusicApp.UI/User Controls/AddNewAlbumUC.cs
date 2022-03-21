
using MusicApp.Entities.Models;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class AddNewAlbumUC : UserControl
    {
        public static event Action<Artist> AlbumAddedEvent;

        public Artist CurrentSelectedArtist { get; set; }
        public AddNewAlbumUC(Artist currentSelectedArtist)
        {
            InitializeComponent();
            CurrentSelectedArtist = currentSelectedArtist;

        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album() 
            {
                AlbumName = textBox1.Text,
                ArtistId = CurrentSelectedArtist.Id,
                DatePublished = dateTimePicker1.Value     
            };

            MusicForm.UserManager.AddToDataBase(newAlbum);
            //CurrentSelectedArtist.Albums.Add(newAlbum);
            MusicForm.UserManager.UpdateToDataBase(CurrentSelectedArtist);
            AlbumAddedEvent(CurrentSelectedArtist);
        }
    }
}
