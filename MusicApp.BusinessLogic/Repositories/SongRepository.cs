using Microsoft.EntityFrameworkCore;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class SongRepository : IDisposable , ISongRepository
    {

        private MusicAppDBContext _context;
        private List<Song> _allSongs;

        public static event Action<Song> SongAddedEvent;
        public static event Action<Song> SongUpdatedEvent;
        public static event Action<string> MessegeEvent;


        public delegate bool SongSearchDelegate(Song song);
        public SongRepository()
        {
            _context = new MusicAppDBContext();
        }

        public Song SearchSong(int id)
        {
            try
            {
                return _context.Songs.Include(s => s.Artist).Include(s => s.Album).Single(s => s.Id == id);

            }
            catch (Exception e)
            {

                MessegeEvent(e.Message);
                return null;
            }

        }
        public List<Song> SearchSongs(SongSearchDelegate searchDelegate)
        {
            try
            {
                _allSongs = _context.Songs.Include(s => s.Artist).Include(s => s.Album).ToList();
                List<Song> list = new List<Song>();
                foreach (var song in _allSongs)
                {
                    if (searchDelegate(song))
                    {
                        list.Add(song);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;

            }
           

        }
        public IEnumerable<Song> GetAll()
        {
            try
            {
                return _context.Songs.ToList();

            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }
        }   
        public void UpdateToDataBase(Song song)
        {
            try
            {
                _context.Songs.Update(song);
                _context.SaveChanges();
                SongUpdatedEvent(song);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);    
            }
           
        }
        public void Delete(int songID)
        {
            try
            {
                var song = _context.Songs.Find(songID);
                _context.Songs.Remove(song);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }

        }
        public async void AddToDataBase(Song song)
        {
            try
            {
                var query = await _context.Songs.AddAsync(song);
                _context.SaveChanges();
                song = _context.Songs.Include(s => s.Artist).Include(s => s.Album).Single(s => s.Id == song.Id);
                SongAddedEvent(song);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }


        }
        public List<Song> GetSongList(Album album)
        {
            try
            {
                var query = _context.Songs.Where(s => s.Album.Id == album.Id).Include(s => s.Album).Select(s => s);
                return query.ToList();
            }
            catch (Exception e)
            {

                MessegeEvent(e.Message);
                return null;
            }


        }
        public List<SongPlayedLog> GetSongLogList(User user)
        {
            try
            {
                var query = _context.SongPlayedLogs.Where(s => s.UserId == user.Id).Include(s => s.Song).ThenInclude(s => s.Artist);
                return query.ToList();
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;

            }

            
        }
        public async void AddSongToSongLog(Song song, User user)
        {
            try
            {
                _context.Songs.Single(s => s.Id == song.Id).Watched++;

                if (_context.SongPlayedLogs.Any(s => s.SongId == song.Id))
                {
                    var songLog = _context.SongPlayedLogs.Single(s => s.SongId == song.Id).TimePlayed = DateTime.Now;

                }
                else
                {
                    SongPlayedLog newSongLoad = new SongPlayedLog()
                    {
                        TimePlayed = DateTime.Now,
                        SongId = song.Id,
                        UserId = user.Id
                    };
                    await _context.SongPlayedLogs.AddAsync(newSongLoad);
                }


                _context.SaveChanges();

            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);       
            }
           
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
