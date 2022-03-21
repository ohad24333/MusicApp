using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class AlbumRepository : IDisposable, IAlbumRepository
    {
        private MusicAppDBContext _context;

        public static event Action<string> MessegeEvent;

        public AlbumRepository()
        {
            _context = new MusicAppDBContext();
        }
        public Album SearchAlbum(int id)
        {
            try
            {
                return _context.Albums.Where(a => a.Id == id).Single();
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }    
        }
        public Album GetAlbum(string name)
        {
            try
            {
                return _context.Albums.Single(a => a.AlbumName == name);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }

        }
        public Album GetAlbum(int? id)
        {
            if (id != null)
            {
                try
                {
                     return _context.Albums.Single(a => a.Id == id);

                }
                catch (Exception e)
                {
                    MessegeEvent(e.Message);
                    return null;

                }

            }
            else return null;

        }
        public async void AddToDataBase(Album album)
        {
            try
            {
                  var query = await _context.Albums.AddAsync(album);
                  _context.SaveChanges();

            }
            catch (Exception e)
            {

                MessegeEvent(e.Message);
            }

        }
        public List<Album> GetAlbumList(Artist artist)
        {
            try
            {
                  var query1 = _context.Albums.Where(album => album.Artist.Id == artist.Id).Select(album => album);
                  return query1.ToList();

            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;

            }

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
