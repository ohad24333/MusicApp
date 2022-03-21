using MusicApp.Entities;
using MusicApp.Entities.Models;
using System.Collections.Generic;
using static MusicApp.BusinessLogic.AppManagement;

namespace MusicApp.BusinessLogic
{
    public interface IUsersRepository
    {
        public void AddUser(User user);
        public void RemoveUser(User user);
        public List<User> SearchUsers(UserSearchDelegate userSearchDelegate);
        public User SearchUser(string email);
        public UserPermissionLevelEnum CheckUserPermissionLevel(User user);
        public void UpdateToDataBase(User user);
    }
}
