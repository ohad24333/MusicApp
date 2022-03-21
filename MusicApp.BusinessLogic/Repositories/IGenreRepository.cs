using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public interface IGenreRepository
    {
        public List<Genre> GetAllGenresList();
        public Genre GetGenre(string name);
    }
}
