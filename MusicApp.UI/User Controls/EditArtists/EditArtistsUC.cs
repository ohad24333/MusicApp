using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using MusicApp.UI.Enums;
using MusicApp.UI.User_Controls;
using MusicApp.UI.User_Controls.EditArtists;
using MusicApp.UI.User_Controls.EditArtists.BackButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class EditArtistsUC : UserControl
    {
        

        public Artist CurrentSelectedArtist { get; set; }
        public Song CurrentSelectedSong { get; set; }
        Album _currentSelectedAlbum;

        ListOnContext _listOnContext;

        public List<Artist> Artists { get; set; } = new List<Artist>();
        public EditArtistsUC()
        {
            InitializeComponent();
            ArtistFoundEvent += artistList =>
            {
                OnArtistFound(artistList);
            };

            BeckButtonPressedEvent += () =>
            {
                _listOnContext.BeckButtonPressedRequest(this);
                
            };

            ListItemUC.BannerClickEvent += (id,type) =>
            {
               
                OnBannerClick(id, type);

            };

            AddNewAlbumUC.AlbumAddedEvent += artist =>
            {
                OnAlbumAdded(artist);
            };

            SongRepository.SongAddedEvent += song =>
            {
                OnBannerClick(song.Id, TypesEnum.Song);
                MessageBox.Show("Song Added Seccessfully!!");

            };

            ArtistRepository.ArtistsAddedEvent += a =>
            {
                MessageBox.Show("Artist Added Seccessfully!!");
                OnBannerClick(a.Id,TypesEnum.Artist);
            };

            ArtistRepository.MessegeEvent += m => MessageBox.Show(m);

            SongRepository.SongUpdatedEvent += s =>
            {
                MessageBox.Show("Song Updated Seccessfully!!");
                OnBannerClick(s.AlbumId.GetValueOrDefault(), TypesEnum.Album);
            };

            //AddNewSongUC.SongAddedEvent += 
        }
        private void EditArtistsUC_Load(object sender, EventArgs e)
        {
            comboxSearchBy.Items.Add("Name");
            comboxSearchBy.Items.Add("Id");
            comboxSearchBy.SelectedIndex = 1;
        }

        public void OnAlbumAdded(Artist artist)
        {
            flowLayoutPanel1.Controls.Clear();

            CurrentSelectedArtist = artist;
            if (CurrentSelectedArtist != null)
            {
                txtStageName.Text = CurrentSelectedArtist.StageName;
                txtFirstName.Text = CurrentSelectedArtist.FirstName;
                txtLastName.Text = CurrentSelectedArtist.LastName;

                List<Album> artistAlbums = MusicForm.UserManager.GetAlbumList(CurrentSelectedArtist);
                if (artistAlbums.Count > 0)
                {



                    foreach (var album in artistAlbums)
                    {
                        ListItemUC Item = new ListItemUC()
                        {
                            Title = $"Album : {album.AlbumName.ToString()}",
                            Info = $"Date Published {album.DatePublished.ToString()}",
                            IconBackground = Color.Silver,
                            Width = flowLayoutPanel1.Width,
                            Id = album.Id,
                            Type = TypesEnum.Album
                            

                        };
                        flowLayoutPanel1.Controls.Add(Item);
                    }
                    Forward.Visible = true;
                    panelEditArtist.Visible = true;
                }
            }
        }

        public void OnBannerClick(int id, TypesEnum type)
        {

            switch (type)
            {
                case Enums.TypesEnum.Artist:
                    flowLayoutPanel1.Controls.Clear();

                    CurrentSelectedArtist = MusicForm.UserManager.SearchArtist(id);
                    txtStageName.Text = CurrentSelectedArtist.StageName;
                    txtFirstName.Text = CurrentSelectedArtist.FirstName;
                    txtLastName.Text = CurrentSelectedArtist.LastName;
                    Forward.Visible = true;
                    panelEditArtist.Visible = true;
                    if (CurrentSelectedArtist != null)
                    {

                        List<Album> artistAlbums = MusicForm.UserManager.GetAlbumList(CurrentSelectedArtist);
                        if (artistAlbums.Count > 0)
                        {
                            foreach (var album in artistAlbums)
                            {
                                ListItemUC Item = new ListItemUC()
                                {
                                    Title = $"Album : {album.AlbumName.ToString()}",
                                    Info = $"Date Published {album.DatePublished.ToString()}",
                                    IconBackground = Color.Silver,
                                    Width = flowLayoutPanel1.Width,
                                    Id = album.Id,
                                    Type = Enums.TypesEnum.Album

                                };
                                flowLayoutPanel1.Controls.Add(Item);
                            }
                           
                        }
                        else MessageBox.Show("No Albums Yet..");


                        _listOnContext = new ListOnContext(new AlbumsListOnUC());
                        btnBack.Visible = true;
                    }
                    break;


                case Enums.TypesEnum.Album:
                    flowLayoutPanel1.Controls.Clear();

                    _currentSelectedAlbum = MusicForm.UserManager.SearchAlbum(id);
                    if (_currentSelectedAlbum != null)
                    {
                        //txtStageName.Text = currentSelectedArtist.StageName;
                        //txtFirstName.Text = currentSelectedArtist.FirstName;
                        //txtLastName.Text = currentSelectedArtist.LastName;

                        List<Song> albumSongs = MusicForm.UserManager.GetSongList(_currentSelectedAlbum);
                        if (albumSongs.Count > 0)
                        {
                            foreach (var song in albumSongs)
                            {
                                ListItemUC Item = new ListItemUC()
                                {
                                    Title = $"Song Name : {song.Name.ToString()}",
                                    Info = $"Date Published {song.DatePublished.ToString()}",
                                    IconBackground = Color.Silver,
                                    Width = flowLayoutPanel1.Width,
                                    Id = song.Id,
                                    Type = Enums.TypesEnum.Song


                                };
                                flowLayoutPanel1.Controls.Add(Item);
                            }
                            Forward.Visible = true;
                            panelEditArtist.Visible = true;
                        }
                        else MessageBox.Show("No Songs Yet..");
                    }
                    _listOnContext = new ListOnContext(new SongsListOnUC());
                    break;
                case Enums.TypesEnum.Song:
                    CurrentSelectedSong = MusicForm.UserManager.SearchSong(id);
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new EditSongMiniUC(CurrentSelectedSong));

                    break;
                default:
                    break;
            }

        }

        public void OnArtistFound(List<Artist> artistList)
        {
            flowLayoutPanel1.Controls.Clear();
            //List<ListItemUC> listArtistsItems = new List<ListItemUC>();
            foreach (var artist in artistList)
            {
                ListItemUC Item = new ListItemUC()
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
            _listOnContext = new ListOnContext(new ArtistsListOnUC());
            
        }
        #region Events

        public static event Action<List<Artist>> ArtistFoundEvent;
        public static event Action BeckButtonPressedEvent;
        public static event Action HomeButtonPressedEvent;
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboxSearchBy.SelectedItem)
            {
                case "Name":
                    Artists = MusicForm.UserManager.SearchArtists(txtSearchInsert.Text);


                    break;
                case "Id":
                    Artists.Clear();
                    Artist artist = MusicForm.UserManager.SearchArtist(int.Parse(txtSearchInsert.Text));
                    if (artist != null)
                    {
                        Artists.Add(artist);
                    }
                    else
                    {
                        MessageBox.Show("Id Is Invalid");
                    }
                    break;
                default:
                    break;
            }
            if (Artists == null)
            {
                MessageBox.Show("Atrist didnt found");
            }
            else
            {
                ArtistFoundEvent(Artists);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Artist> list = new List<Artist>();
            for (int i = 0; i < 6; i++)
            {
                list.Add(new Artist() { StageName = "StageName " + i, FirstName = "Name " + i, LastName = "xfgx" });
            }


            ArtistFoundEvent(list);
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            txtStageName.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            Forward.Visible = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            CurrentSelectedArtist.StageName = txtStageName.Text;
            CurrentSelectedArtist.FirstName = txtFirstName.Text;
            CurrentSelectedArtist.LastName = txtLastName.Text;

            MusicForm.UserManager.UpdateToDataBase(CurrentSelectedArtist);

            txtStageName.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            Forward.Visible = true;
            btnSave.Visible = false;
        }

        private void btnAddNewAlbum_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AddNewAlbumUC(CurrentSelectedArtist));
        }

      



        public void MakeBackButtonUnvisible()
        {
            btnBack.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BeckButtonPressedEvent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeButtonPressedEvent();
        }

        private void btnAddANewArtist_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AddNewArtistUC(this));
        }

        private void btnAddNewSong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AddNewSongUC(CurrentSelectedArtist));
        }

        private void comboxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSearchArtist_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchInsert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
