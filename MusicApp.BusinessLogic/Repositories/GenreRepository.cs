using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class GenreRepository : IDisposable , IGenreRepository
    {
        private MusicAppDBContext _context;

        public static event Action<string> MessegeEvent;
        public GenreRepository()
        {
            _context = new MusicAppDBContext();
        }
        public List<Genre> GetAllGenresList()
        {
            try
            {
                return _context.Genres.Select(g => g).ToList();
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }
           

        }
        public Genre GetGenre(string name)
        {
            try
            {
                return _context.Genres.Where(g => g.Name == name).Select(g => g).Single();
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
