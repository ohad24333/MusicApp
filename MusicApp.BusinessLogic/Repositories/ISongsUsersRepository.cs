using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public interface ISongsUsersRepository
    {
        public  void AddSongToUserSongList(Song song, User user);
        public void RemoveSongFromUserSongList(Song song, User user);
        public List<SongsUser> GetSongUserList(User user);
        public bool CheckIfSongOnPlaylist(Song song, User user);


    }
}
