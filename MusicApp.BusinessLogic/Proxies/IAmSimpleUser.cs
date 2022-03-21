using MusicApp.Entities.Models;
using System.Collections.Generic;
using static MusicApp.BusinessLogic.SongRepository;

namespace MusicApp.BusinessLogic
{
    public interface IAmSimpleUser
    {
        #region Song Methodes
        public void AddSongToUserSongList(Song song, User user);
        public void RemoveSongFromUserSongList(Song song, User user);
        public List<Song> SearchSongs(SongSearchDelegate songSearchDelegate);
        public List<SongsUser> GetSongUserList(User user);
        public List<Artist> SearchArtists(string artistSearchText);
        public Artist SearchArtist(int id);
        public bool CheckIfSongOnPlaylist(Song song, User user);
        public List<Album> GetAlbumList(Artist artist);

        public T DeepCopy<T>(T self);

        public Coutry GetArtistCoutry(Artist artist);


        public List<SongPlayedLog> GetSongLogList(User user);
        public void AddSongToSongLog(Song song, User user);


        public List<Genre> GetAllGenresList();

        public Genre GetGenre(string name);
        public Album GetAlbum(string name);
        public Album GetAlbum(int? id);
        public Publisher GetPublisher(string name);

        public List<Publisher> GetAllPublishersList();
        public void AddToDataBase(Song song);
       
        public Album SearchAlbum(int id);

        public List<Song> GetSongList(Album album);

        public List<Coutry> GetAllCountries();

        public Song SearchSong(int id);
        #endregion
    }
}