using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public interface IAlbumRepository
    {
        public Album SearchAlbum(int id);
        public Album GetAlbum(string name);
        public Album GetAlbum(int? id);
        public void AddToDataBase(Album album);
        public List<Album> GetAlbumList(Artist artist);

    }
}
