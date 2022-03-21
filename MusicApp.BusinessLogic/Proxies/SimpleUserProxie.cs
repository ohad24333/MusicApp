using MusicApp.Entities.Models;
using System.Collections.Generic;
using static MusicApp.BusinessLogic.AppManagement;
using static MusicApp.BusinessLogic.SongRepository;

namespace MusicApp.BusinessLogic
{
    public class SimpleUserProxie : IAmUser
    {
        private AppManagement _appManagement = new AppManagement();


        #region Song Methodes
        public void AddSongToUserSongList(Song song, User user)
        {
            _appManagement.AddSongToUserSongList(song, user);
        }
        public void RemoveSongFromUserSongList(Song song, User user)
        {
            _appManagement.RemoveSongFromUserSongList(song, user);
        }
        public List<Song> SearchSongs(SongSearchDelegate songSearchDelegate)
        {
            return _appManagement.SearchSongs(songSearchDelegate);
        }
        public Song SearchSong(int id)
        {
            return _appManagement.SearchSong(id);
        }
        public List<Song> GetSongList(Album album)
        {
            return _appManagement.GetSongList(album);
        }
        public void PlaySong(Song song, User user)
        {
            _appManagement.PlaySong(song, user);
        }
        public void UpdateToDataBase(Song song)
        {

        }
        public void AddSongToAllSongList(Song song)
        {
          
        }

     
        #endregion


        #region Artist Methodes
        public List<Artist> SearchArtists(string artistSearch)
        {
            return _appManagement.SearchArtists(artistSearch);
        }

        public Artist SearchArtist(int id)
        {
            return _appManagement.SearchArtist(id);
        }

        public Coutry GetArtistCoutry(Artist artist)
        {
            return _appManagement.GetArtistCoutry(artist);
        }

        public void UpdateToDataBase(Artist artist)
        {

        }




        #endregion


        #region Other Methodes
        public List<Album> GetAlbumList(Artist artist)
        {
            return _appManagement.GetAlbumList(artist);
        }

        public T DeepCopy<T>(T self)
        {
            return _appManagement.DeepCopy(self);
        }
      
      
        public void AddToDataBase(Album album)
        {
           
        }

        public List<Genre> GetAllGenresList()
        {
            return _appManagement.GetAllGenresList();
        }

        public Genre GetGenre(string name)
        {
            return _appManagement.GetGenre(name);
        }

        public List<Publisher> GetAllPublishersList()
        {
            return _appManagement.GetAllPublishersList();
        }

        public void AddToDataBase(Song song)
        {
           
        }

        public Album SearchAlbum(int id)
        {
            return _appManagement.SearchAlbum(id);
        }

      

        public void AddToDataBase(Artist artist)
        {
           
        }

        public List<Coutry> GetAllCountries()
        {
            return _appManagement.GetAllCountries();
        }

        public Publisher GetPublisher(string name)
        {
            return _appManagement.GetPublisher(name);
        }

        public Album GetAlbum(string name)
        {
            return _appManagement.GetAlbum(name);
        }


        #endregion


        #region User Methodes

        public void AddUser(User user)
        {
            
        }

        public void RemoveUser(User user)
        {
          
        }

        public User SearchUser(string email)
        {
            return null;
        }

        public List<SongsUser> GetSongUserList(User user)
        {
            return _appManagement.GetSongUserList(user);
        }

        public Album GetAlbum(int? id)
        {
            return _appManagement.GetAlbum(id);
        }

        public void UpdateToDataBase(User song)
        {
            
        }

        public List<SongPlayedLog> GetSongLogList(User user)
        {
            return _appManagement.GetSongLogList(user);
        }

        public void AddSongToSongLog(Song song, User user)
        {
            _appManagement.AddSongToSongLog(song, user);
        }

        public List<User> SearchUsers(UserSearchDelegate userSearchDelegate)
        {
            return _appManagement.SearchUsers(userSearchDelegate);
        }

        public bool CheckIfSongOnPlaylist(Song song, User user)
        {
            return _appManagement.CheckIfSongOnPlaylist(song, user);
        }



        #endregion


    }
}
