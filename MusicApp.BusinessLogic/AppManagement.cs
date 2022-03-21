using MusicApp.Entities;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static MusicApp.BusinessLogic.SongRepository;

namespace MusicApp.BusinessLogic
{
    public class AppManagement : IAmUser
    {
        #region Delegates 

        public delegate bool UserSearchDelegate(User user);

        public delegate Artist ArtistSearchDelegate(Artist artist);

        public static event Action<string> MessegeEvent;

        #endregion



        #region Admin Methods

        #region Users Repository  
        public void AddUser(User user)
        {
            UsersRepository usersRepository = new UsersRepository();
            usersRepository.AddUser(user);
            usersRepository.Dispose();

        }
        public void RemoveUser(User user)
        {
            UsersRepository usersRepository = new UsersRepository();
            usersRepository.RemoveUser(user);
            usersRepository.Dispose();
        }
        public List<User> SearchUsers(UserSearchDelegate userSearchDelegate)
        {
            UsersRepository usersRepository = new UsersRepository();
            var list = usersRepository.SearchUsers(userSearchDelegate);
            usersRepository.Dispose();
            return list;

        }
        public User SearchUser(string email)
        {
            UsersRepository usersRepository = new UsersRepository();
            var user = usersRepository.SearchUser(email);
            usersRepository.Dispose();
            return user;

        }
        public UserPermissionLevelEnum CheckUserPermissionLevel(User user)
        {
            UsersRepository usersRepository = new UsersRepository();
            UserPermissionLevelEnum upe = usersRepository.CheckUserPermissionLevel(user);
            usersRepository.Dispose();
            return upe;
        }
        public void UpdateToDataBase(User user)
        {
            UsersRepository usersRepository = new UsersRepository();
            usersRepository.UpdateToDataBase(user);
            usersRepository.Dispose();

        }
        #endregion

        #endregion



        #region All Users Methodes

        #region Song Repo
        public void AddToDataBase(Song song)
        {
            SongRepository songRepository = new SongRepository();
            songRepository.AddToDataBase(song);
            songRepository.Dispose();
        }
        public Song SearchSong(int id)
        {
            SongRepository songRepository = new SongRepository();
            Song song = songRepository.SearchSong(id);
            songRepository.Dispose();
            return song;
        }
        public List<Song> SearchSongs(SongSearchDelegate songSearchDelegate)
        {
            SongRepository songRepository = new SongRepository();
            List<Song> songsList = songRepository.SearchSongs(songSearchDelegate);
            songRepository.Dispose();
            return songsList;
        }
        public void UpdateToDataBase(Song song)
        {
            SongRepository songRepository = new SongRepository();
            songRepository.UpdateToDataBase(song);
            songRepository.Dispose();
        }
        public List<Song> GetSongList(Album album)
        {
            SongRepository songRepository = new SongRepository();
            var list = songRepository.GetSongList(album);
            songRepository.Dispose();
            return list;
        }
        public List<SongPlayedLog> GetSongLogList(User user)
        {
            SongRepository songRepository = new SongRepository();
            var list = songRepository.GetSongLogList(user);
            songRepository.Dispose();
            return list;
        }
        public void AddSongToSongLog(Song song, User user)
        {
            SongRepository songRepository = new SongRepository();
            songRepository.AddSongToSongLog(song, user);
            songRepository.Dispose();
        }
        #endregion

        #region Artist Repo
        public void AddToDataBase(Artist artist)
        {
            ArtistRepository artistRepository = new ArtistRepository();
            artistRepository.AddToDataBase(artist);
            artistRepository.Dispose();
        }
        public Artist SearchArtist(int id)
        {
            ArtistRepository artistRepository = new ArtistRepository();
            Artist artist = artistRepository.SearchArtist(id);
            artistRepository.Dispose();
            return artist;

        }
        public List<Artist> SearchArtists(string txtSearchInsert)
        {
            ArtistRepository artistRepository = new ArtistRepository();
            List<Artist> list = artistRepository.SearchArtists(txtSearchInsert);
            artistRepository.Dispose();
            return list;
        }
        public void UpdateToDataBase(Artist artist)
        {
            ArtistRepository artistRepository = new ArtistRepository();
            artistRepository.UpdateToDataBase(artist);
            artistRepository.Dispose();
        }
        public Coutry GetArtistCoutry(Artist artist)
        {
            ArtistRepository artistRepository = new ArtistRepository();
            Coutry coutry = artistRepository.GetArtistCoutry(artist);
            artistRepository.Dispose();
            return coutry;
        }
        #endregion

        #region Album Repo
        public Album SearchAlbum(int id)
        {
            AlbumRepository albumRepository = new AlbumRepository();
            Album album = albumRepository.SearchAlbum(id);
            albumRepository.Dispose();
            return album;
        }
        public Album GetAlbum(string name)
        {

            AlbumRepository albumRepository = new AlbumRepository();
            Album album = albumRepository.GetAlbum(name);
            albumRepository.Dispose();
            return album;
        }
        public Album GetAlbum(int? id)
        {
            AlbumRepository albumRepository = new AlbumRepository();
            Album album = albumRepository.GetAlbum(id);
            albumRepository.Dispose();
            return album;

        }
        public void AddToDataBase(Album album)
        {
            AlbumRepository albumRepository = new AlbumRepository();
            albumRepository.AddToDataBase(album);
            albumRepository.Dispose();
        }
        public List<Album> GetAlbumList(Artist artist)
        {
            AlbumRepository albumRepository = new AlbumRepository();
            var list = albumRepository.GetAlbumList(artist);
            albumRepository.Dispose();
            return list;

        }
        #endregion

        #region Songs Users Repo

        public void AddSongToUserSongList(Song song, User user)
        {
            SongsUsersRepository songsUsersRepository = new SongsUsersRepository();
            songsUsersRepository.AddSongToUserSongList(song, user);
            songsUsersRepository.Dispose();


        }

        public void RemoveSongFromUserSongList(Song song, User user)
        {
            SongsUsersRepository songsUsersRepository = new SongsUsersRepository();
            songsUsersRepository.RemoveSongFromUserSongList(song, user);
            songsUsersRepository.Dispose();

        }

        public List<SongsUser> GetSongUserList(User user)
        {
            SongsUsersRepository songsUsersRepository = new SongsUsersRepository();
            var list = songsUsersRepository.GetSongUserList(user);
            songsUsersRepository.Dispose();
            return list;
        }

        public bool CheckIfSongOnPlaylist(Song song, User user)
        {
            SongsUsersRepository songsUsersRepository = new SongsUsersRepository();
            var isOnList = songsUsersRepository.CheckIfSongOnPlaylist(song, user);
            songsUsersRepository.Dispose();
            return isOnList;
        }


        #endregion

        #region Genre Repository
        public List<Genre> GetAllGenresList()
        {
            GenreRepository genreRepository = new GenreRepository();
            var list = genreRepository.GetAllGenresList();
            genreRepository.Dispose();
            return list;

        }

        public Genre GetGenre(string name)
        {
            GenreRepository genreRepository = new GenreRepository();
            var genre = genreRepository.GetGenre(name);
            genreRepository.Dispose();
            return genre;
        }
        #endregion

        #region Publisher Repository
        public List<Publisher> GetAllPublishersList()
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            var list = publisherRepository.GetAllPublishersList();
            publisherRepository.Dispose();
            return list;
        }

        public Publisher GetPublisher(string name)
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            var publisher = publisherRepository.GetPublisher(name);
            publisherRepository.Dispose();
            return publisher;
        }

        #endregion


        #region Song Actions

        public void PlaySong(Song song, User user)
        {
            SongActions.PlaySong(song, user);
        }

        #endregion

        public List<Coutry> GetAllCountries()
        {
            using (var db = new MusicAppDBContext())
            {
                return db.Coutries.ToList();
            }
        }
        public T DeepCopy<T>(T self)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(self);
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
        #endregion

        #region Sign In Methods

        public void CheckSignInCollumnsValidilty(User user)
        {
            string messege = "";


            if (!Regexes.EmailRegex.IsMatch(user.Email))
            {
                messege += "Email Is Invalid\n";
            }
            if (!Regexes.NameRegex.IsMatch(user.FirstName))
            {
                messege += ("First Name Can Include Only A-z Characters And Long Between 2-10\n");
            }
            if (!Regexes.NameRegex.IsMatch(user.LastName))
            {
                messege += ("last Name Can Include Only A-z Characters And Long Between 2-10\n");
            }
            if (messege != "")
            {
                MessegeEvent(messege);
                return;
            }
            else
            {
                user.PermissionLevel = 1;
                AddUser(user);
            }
        }


        #endregion

        #region Forgot Passward Methods

        public void SendEmailWithPassward(string email)
        {

            if (!Regexes.EmailRegex.IsMatch(email))
            {
                MessegeEvent("Email Is Invalid");
                return;
            }
            using (var db = new MusicAppDBContext())
            {
                if (db.Users.Any(u => u.Email.ToLower() == email.ToLower()))
                {
                    MessegeEvent($"**********THIS IS EMAIL!!!!***********\nThe Passward Is: {db.Users.Single(u => u.Email == email).Password} ");
                }
                else
                {
                    MessegeEvent("This Email Is Not Sign In");
                }
            }

        }



        #endregion
    }
}
