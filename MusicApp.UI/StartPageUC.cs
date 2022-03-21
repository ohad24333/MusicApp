using MusicApp.BusinessLogic;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class StartPageUC : UserControl
    {
        public User UserConnected { get; set; }

        public StartPageUC()
        {
            InitializeComponent();


            ListItemUC4.BannerClickEvent4 += (id, type) =>
            {

                DisplayOnPlaySongPannel(SongsList, id);
            };
            SongPlayingUC.AddToPlayListEvent += s =>
            {
                MusicForm.UserManager.AddSongToUserSongList(s, MusicForm.UserConnected);
                OnSongSavedClick();
            };
            SongPlayingUC.RemoveFromPlayListEvent += s =>
            {
                MusicForm.UserManager.RemoveSongFromUserSongList(s, MusicForm.UserConnected);
                OnSongSavedClick();
                fLPSongs.Controls.Clear();

            };
            AppManagement.MessegeEvent += m => MessageBox.Show(m);

        }
        public StartPageUC(User user)
        {
            InitializeComponent();

            UserConnected = user;

            ListItemUC4.BannerClickEvent4 += (id, type) =>
            {

                DisplayOnPlaySongPannel(SongsList, id);
            };
            SongPlayingUC.AddToPlayListEvent += s =>
            {
                MusicForm.UserManager.AddSongToUserSongList(s, MusicForm.UserConnected);
                OnSongSavedClick();
            };
            SongPlayingUC.RemoveFromPlayListEvent += s =>
            {
                MusicForm.UserManager.RemoveSongFromUserSongList(s, MusicForm.UserConnected);
                OnSongSavedClick();
                fLPSongs.Controls.Clear();
            };

            SongsUsersRepository.MessegeEvent += m => MessageBox.Show(m);

        }

        public List<Song> SongsList { get; set; } = new List<Song>();


        public static event Action EditArtistEvent;
        public static event Action EditSongsEvent;
        public static event Action EditUsersEvent;
        //public static event Action<User> EditUserEvent;
        public static event Action DisconectEvent;

        private void StartPageUC_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {MusicForm.UserConnected.FirstName} {MusicForm.UserConnected.LastName}";
            comboxSearchBy.Items.Add("Song Name");
            comboxSearchBy.Items.Add("Artist");
            comboxSearchBy.SelectedIndex = 0;
            UserConnected = MusicForm.UserConnected;
            if (UserConnected.PermissionLevel == 1)
            {
                btnEditArtists.Visible = false;
                btnEditSongs.Visible = false;
                btnEditUsers.Visible = false;
                lblAdminOptions.Visible = false;
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {



            SongsList = new List<Song>();

            switch (comboxSearchBy.Text)
            {
                case "Song Name":
                    SongsList = MusicForm.UserManager.SearchSongs(s => s.Name.ToLower().StartsWith(txtSearchInsert.Text.ToLower()));


                    break;
                case "Artist":
                    SongsList = MusicForm.UserManager.SearchSongs(s => s.Artist.StageName.ToLower().StartsWith(txtSearchInsert.Text.ToLower()));

                    break;
                default:
                    break;
            }

            if (SongsList.Count > 0)
            {
                SongsList.Sort(new SongNameCompare());
                DisplayOnLayoutPannel(SongsList);
            }
            else MessageBox.Show("No Songs Found...");

        }
        private void DisplayOnLayoutPannel(List<Song> songsList)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var song in songsList)
            {


                string albumName = MusicForm.UserManager.GetAlbum(song.AlbumId).AlbumName;

                if (albumName == null)
                {
                    albumName = "None";
                }
                ListItemUC4 Item = new ListItemUC4()
                {
                    Title = song.Name,
                    Info = $"Artist : {song.Artist.StageName} Album : {albumName}\n" +
                    $"Duration : {song.Duration.Minute}:{song.Duration.Second}",
                    IconBackground = Color.Silver,
                    Width = flowLayoutPanel1.Width,
                    Id = song.Id,
                };

                //  listArtistsItems.Add(Item);

                flowLayoutPanel1.Controls.Add(Item);
            }
        }
        private void DisplayOnPlaySongPannel(List<Song> songs, int songId)
        {



            fLPSongs.Controls.Clear();
            Song song = MusicForm.UserManager.SearchSong(songId);
            string albumName = MusicForm.UserManager.GetAlbum(song.AlbumId).AlbumName;
            if (albumName == null)
            {
                albumName = "None";
            }

            SongPlayingUC Item = new SongPlayingUC()
            {
                Title = song.Name,
                Info = $"Artist : {song.Artist.StageName} Album : {albumName}\n" +
                $"Duration : {song.Duration.Minute}:{song.Duration.Second}",
                Duration = song.Duration,
                IconBackground = Color.Silver,
                Width = fLPSongs.Width,
                Height = fLPSongs.Height,
                Id = song.Id,
                PlayListOn = songs,
                NowPlayingSong = song,
                Watched = song.Watched,
                PlayListCounter = songs.FindIndex(s => s.Id == song.Id)
            };



            fLPSongs.Controls.Add(Item);
            MusicForm.UserManager.AddSongToSongLog(song, MusicForm.UserConnected);

        }
        private void btnEditArtists_Click(object sender, EventArgs e)
        {
            EditArtistEvent();
        }
        private void btnListeningHistory_Click(object sender, EventArgs e)
        {
            List<SongPlayedLog> songPlayedLogs = MusicForm.UserManager.GetSongLogList(MusicForm.UserConnected);
            if (songPlayedLogs.Count > 0)
            {
                songPlayedLogs.Sort(new SongLastPlayedCompare());
                SongsList = new List<Song>();
                songPlayedLogs.ForEach(s => SongsList.Add(s.Song));
                DisplayOnLayoutPannel(SongsList);
            }
            else MessageBox.Show("No Songs Found...");

        }
        private void btnSongSaved_Click(object sender, EventArgs e)
        {
            OnSongSavedClick();

        }
        private void OnSongSavedClick()
        {

            List<SongsUser> songsUsers = MusicForm.UserManager.GetSongUserList(MusicForm.UserConnected);
            SongsList = new List<Song>();
            songsUsers.ForEach(s => SongsList.Add(s.Song));
            if (SongsList.Count > 0)
            {
                SongsList.Sort(new SongNameCompare());
                DisplayOnLayoutPannel(SongsList);
            }
            else MessageBox.Show("No Songs Found...");
        }
        private void btnEditSongs_Click(object sender, EventArgs e)
        {
            EditSongsEvent();
        }
        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            EditUsersEvent();
        }
        private void lblDisconect_Click(object sender, EventArgs e)
        {
            DisconectEvent();
        }

    }
}
