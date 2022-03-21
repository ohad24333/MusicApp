using Microsoft.EntityFrameworkCore;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class SongsUsersRepository : IDisposable , ISongsUsersRepository
    {
        private MusicAppDBContext _context;

        public static event Action<string> MessegeEvent;
        public SongsUsersRepository()
        {
            _context = new MusicAppDBContext();
        }
        public async void AddSongToUserSongList(Song song, User user)
        {
            try
            {
                if (!(_context.SongsUsers.Any(su => su.SongId == song.Id && su.UserId == user.Id)))
                {
                    await _context.SongsUsers.AddAsync(new SongsUser() { SongId = song.Id, UserId = user.Id });
                    _context.SaveChanges();
                    MessegeEvent("Song Added Successfuly");
                }
                else
                {
                    MessegeEvent("Song Already In List");
                }
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }
          


        }
        public void RemoveSongFromUserSongList(Song song, User user)
        {
            try
            {
                if (_context.SongsUsers.Any(sl => sl.SongId == song.Id))
                {
                    _context.SongsUsers.Remove(_context.SongsUsers.Single(su => su.UserId == user.Id && su.SongId == song.Id));
                    _context.SaveChanges();
                    MessegeEvent("Song Removed Successfuly");
                }
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }



        }
        public List<SongsUser> GetSongUserList(User user)
        {
            try
            {
                var query = _context.SongsUsers.Where(s => s.UserId == user.Id).Include(s => s.Song).ThenInclude(s => s.Artist);
                return query.ToList();
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }

        }
        public bool CheckIfSongOnPlaylist(Song song, User user)
        {
            try
            {
                return _context.SongsUsers.Any(su => su.SongId == song.Id && su.UserId == user.Id);
            }
            catch (Exception e)
            {

                MessegeEvent(e.Message);
                return false;

            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
