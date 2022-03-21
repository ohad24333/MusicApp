using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class SongPlayingUC : UserControl
    {
        public SongPlayingUC()
        {
            InitializeComponent();

            
        }

        //public static event Action<int> BannerClickEvent;
        public static event Action<Song> AddToPlayListEvent;
        public static event Action<Song> RemoveFromPlayListEvent;
        public Song NowPlayingSong { get; set; }
        public List<Song> PlayListOn { get; set; }


        #region Props
       

        private string _title;

        private string _info;

        private Image _icon;

        private Color _iconBackground;

        private int _id;

        private int _progress;
        public DateTime Duration { get; set; }
        public int DurationInSeconds { get; set; }

        public int PlayListCounter { get; set; }

        Timer timer;

        public int _watched { get; set; }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

          [Category("Custom Props")]
        public int Watched
        {
            get { return _watched; }
            set { _watched = value; lblWatchedCounter.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBackground; }
            set { _iconBackground = value; panel1.BackColor = value; }
        }


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Info
        {
            get { return _info; }
            set { _info = value; lblText.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]

        public int Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }
        [Category("Custom Props")]


        #endregion

        private void SongPlayingUC_Load(object sender, EventArgs e)
        {
            if (PlayListOn.Count <= 1 || PlayListCounter == PlayListOn.Count -1)
            {
                btnNext.Enabled = false;
            }
            if (PlayListCounter > 0)
            {
                btnBack.Enabled = true;
            }
            DurationInSeconds = (Duration.Minute * 60) + Duration.Second;
            progressBar1.Value = 0;
            PlayTimer();
            switch (MusicForm.UserManager.CheckIfSongOnPlaylist(NowPlayingSong , MusicForm.UserConnected))
            {
                case false:
                    btnAddToPlayList.Text = "+ Add To Play List";
                    break;
                case true:
                    btnAddToPlayList.Text = "- Remove From Play List";
                    break;

            }

        }   
        private void PopulateDataOnScrean(Song song)
        {
            Title = song.Name;
            string albumName = MusicForm.UserManager.GetAlbum(song.AlbumId).AlbumName;
            if (albumName == null)
            {
                albumName = "None";
            }

            Info = $"Artist : {song.Artist.StageName} Album : {albumName}\n" +
            $"Duration : {song.Duration.Minute}:{song.Duration.Second}";
            Duration = song.Duration;
            Id = song.Id;
            DurationInSeconds = (song.Duration.Minute * 60) + song.Duration.Second;
            progressBar1.Value = 0;
            Progress = 0;
            lblWatchedCounter.Text = song.Watched.ToString();
            PlayTimer();
            switch (MusicForm.UserManager.CheckIfSongOnPlaylist(NowPlayingSong, MusicForm.UserConnected))
            {
                case false:
                    btnAddToPlayList.Text = "+ Add To Play List";
                    break;
                case true:
                    btnAddToPlayList.Text = "- Remove From Play List";
                    break;

            }
        }
        private void AddSongPlayesToUserDetailes(Song song)
        {
            MusicForm.UserManager.AddSongToSongLog(song, MusicForm.UserConnected);
        } 
        private void PlayTimer()
        {      
            timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000;
            timer.Start();
            progressBar1.Maximum = DurationInSeconds;
            progressBar1.Value = Progress;
            lblTimer.Text = Progress.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress++;
            if (DurationInSeconds == 0)
            {
                return;
            }
            if (Progress == DurationInSeconds)
                timer.Stop();
            progressBar1.Value = Progress;
            lblTimer.Text = Progress.ToString();

        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            switch (btnPlayPause.Text)
            {
                case "Play":
                    btnPlayPause.Text = "Pause";
                    timer.Start();
                        break;
                case "Pause":
                    btnPlayPause.Text = "Play";
                    timer.Stop();
                    break;
                default:
                    break;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            Progress =  0;
            progressBar1.Value = 0;
            lblTimer.Text = progressBar1.Value.ToString();
            btnPlayPause.Text = "Play";
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            PlayListCounter++;
            btnBack.Enabled = true;

            if (PlayListOn.Count -2 < PlayListCounter)
            {
                btnNext.Enabled = false;
            }
            timer.Dispose();
            NowPlayingSong = PlayListOn[PlayListCounter];
            NowPlayingSong.Watched++;
            PopulateDataOnScrean(NowPlayingSong);
            AddSongPlayesToUserDetailes(NowPlayingSong);
            btnPlayPause.Text = "Pause";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            PlayListCounter--;
            btnNext.Enabled = true;

            if (PlayListCounter == 0)
            {
                btnBack.Enabled = false;
            }
            timer.Dispose();
            NowPlayingSong = PlayListOn[PlayListCounter];
            NowPlayingSong.Watched++;
            PopulateDataOnScrean(NowPlayingSong);
            AddSongPlayesToUserDetailes(NowPlayingSong);
            btnPlayPause.Text = "Pause";
        }
        private void btnAddToPlayList_Click(object sender, EventArgs e)
        {
            switch (btnAddToPlayList.Text)
            {
                case "- Remove From Play List":
                    
                    RemoveFromPlayListEvent(NowPlayingSong);
                    btnAddToPlayList.Text = "+ Add To Play List";
                    break;
                case "+ Add To Play List":
                    AddToPlayListEvent(NowPlayingSong);
                    btnAddToPlayList.Text = "- Remove From Play List";
                    break;
                default:
                    break;
            }
          
        }
    }
}
