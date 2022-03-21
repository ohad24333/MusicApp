using MusicApp.Entities;
using MusicApp.Entities.Models;

namespace MusicApp.BusinessLogic
{
    public interface IBeforeLogin
    {
        public User SearchUser(string email);
        public UserPermissionLevelEnum CheckUserPermissionLevel(User user);

    }
}
