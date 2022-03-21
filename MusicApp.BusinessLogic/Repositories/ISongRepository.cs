using MusicApp.Entities.Models;
using System.Collections.Generic;
using static MusicApp.BusinessLogic.SongRepository;

namespace MusicApp.BusinessLogic
{
    public interface ISongRepository
    {
        public Song SearchSong(int id);
        public List<Song> SearchSongs(SongSearchDelegate searchDelegate);
        public IEnumerable<Song> GetAll();
        public void UpdateToDataBase(Song song);
        public void Delete(int songID);
        public void AddToDataBase(Song song);
        public List<Song> GetSongList(Album album);
        public List<SongPlayedLog> GetSongLogList(User user);
        public void AddSongToSongLog(Song song, User user);    
    }






}
