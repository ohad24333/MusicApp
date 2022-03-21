using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public interface IArtistRepository
    {
        public void AddToDataBase(Artist artist);
        public Artist SearchArtist(int id);
        public List<Artist> SearchArtists(string txtSearchInsert);
        public void UpdateToDataBase(Artist artist);
        public Coutry GetArtistCoutry(Artist artist);
    }
}
