using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using MusicApp.UI.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class EditSongUC : UserControl
    {

        public List<Song> Songs { get; set; }
        public Song CurrentSelectedSong { get; set; }

        public static event Action<User> HomeButtonPressedEvent;
        public EditSongUC()
        {
            InitializeComponent();

            ListItemUC2.BannerClickEvent2 += (id, type) =>
            {

                OnBannerClick(id, type);

            };

            ChooseArtistUC.EditArtistFound += a =>
            {
                OnArtistFound(a);
            };

            SongRepository.SongUpdatedEvent += s =>
            {
                flowLayoutPanel1.Controls.Clear();

                txtSongName.Text = s.Name;
                txtArtist.Text = s.Artist.StageName;
                txtAlbum.Text = s.Album.AlbumName;
                panelEditArtist.Visible = true;
                ShowSongsOnPannel(new List<Song>() { s });
            };

            SongRepository.SongAddedEvent += s =>
            {
                flowLayoutPanel1.Controls.Clear();


                txtSongName.Text = s.Name;
                txtArtist.Text = s.Artist.StageName;
                txtAlbum.Text = s.Album.AlbumName;
                panelEditArtist.Visible = true;
                ShowSongsOnPannel(new List<Song>() { s });
            };
        }

        private void OnBannerClick(int id, TypesEnum type)
        {
            switch (type)
            {
                case Enums.TypesEnum.Song:
                    flowLayoutPanel1.Controls.Clear();

                    CurrentSelectedSong = MusicForm.UserManager.SearchSong(id);
                    txtSongName.Text = CurrentSelectedSong.Name;
                    txtArtist.Text = CurrentSelectedSong.Artist.StageName;
                    txtAlbum.Text = CurrentSelectedSong.Album.AlbumName;
                    panelEditArtist.Visible = true;
                    flowLayoutPanel1.Controls.Add(new EditSongMiniUC(CurrentSelectedSong));
                    break;
                case Enums.TypesEnum.Artist:
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new AddNewSongUC(MusicForm.UserManager.SearchArtist(id)));
                    break;
            }
        }
        public void OnArtistFound(List<Artist> artistList)
        {
            flowLayoutPanel1.Controls.Clear();
            //List<ListItemUC> listArtistsItems = new List<ListItemUC>();
            foreach (var artist in artistList)
            {
                ListItemUC2 Item = new ListItemUC2()
                {
                    Title = artist.StageName,
                    Info = $"Full name : {artist.FirstName} {artist.LastName}\nFrom : {MusicForm.UserManager.GetArtistCoutry(artist).Name}",
                    IconBackground = Color.Silver,
                    Width = flowLayoutPanel1.Width,
                    Id = artist.Id
                };

                //  listArtistsItems.Add(Item);

                flowLayoutPanel1.Controls.Add(Item);
            }


        }



        private void EditSongUC_Load(object sender, EventArgs e)
        {
            comboxSearchBy.Items.Add("Name");
            comboxSearchBy.Items.Add("Id");
            comboxSearchBy.SelectedIndex = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboxSearchBy.SelectedItem)
            {
                case "Name":
                    Songs = MusicForm.UserManager.SearchSongs(s => s.Name.ToLower().StartsWith(txtSearchInsert.Text.ToLower()));


                    break;
                case "Id":
                    var regex = new Regex(@"[1-9]");
                    if (regex.IsMatch(txtSearchInsert.Text))
                    {
                        Songs = MusicForm.UserManager.SearchSongs(s => s.Id.ToString() == txtSearchInsert.Text);

                    }
                    else
                    {
                        MessageBox.Show("Id Is Invalid, Id Shoulde Be Only Numbers");
                        return;
                    }
                    break;
                default:
                    break;
            }
            if (Songs.Count == 0)
            {
                MessageBox.Show("Song didnt found");
            }
            else
            {
                ShowSongsOnPannel(Songs);
            }
        }


        public void ShowSongsOnPannel(List<Song> songstList)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var song in songstList)
            {
                ListItemUC2 Item = new ListItemUC2()
                {
                    Title = song.Name,
                    Info = $"Song Name : {song.Name} \nArtist : {song.Artist.StageName}\nAlbum : {song.Album.AlbumName}",
                    IconBackground = Color.Silver,
                    Width = flowLayoutPanel1.Width,
                    Id = song.Id,
                    Type = TypesEnum.Song
                };


                flowLayoutPanel1.Controls.Add(Item);
            }


        }

      

        private void btnAddANewSong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ChooseArtistUC());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeButtonPressedEvent(MusicForm.UserConnected);
        }
    }
}
