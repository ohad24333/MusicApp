using MusicApp.Entities.Models;
using System;

namespace MusicApp.BusinessLogic
{
    public static class SongActions
    {
        public static void PlaySong(Song song, User user)
        {
            user.UserListeningHistory.Add(new SongPlayedLog() { TimePlayed = DateTime.Now, SongId = song.Id });
        }
        public static void StopSong(Song song, User user)
        {

        }
    }
}
