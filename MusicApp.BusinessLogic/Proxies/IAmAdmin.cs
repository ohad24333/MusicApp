using MusicApp.Entities.Models;
using System.Collections.Generic;
using static MusicApp.BusinessLogic.AppManagement;

namespace MusicApp.BusinessLogic
{
    public interface IAmAdmin 
    {

        public void AddToDataBase(Album album);
        public void AddToDataBase(Artist artist);
        public void UpdateToDataBase(Artist artist);
        public void UpdateToDataBase(Song song);
        public void UpdateToDataBase(User song);
        public void AddUser(User user);
        public void RemoveUser(User user);
        public User SearchUser(string email);
        public List<User> SearchUsers(UserSearchDelegate userSearchDelegate);
    }
}
