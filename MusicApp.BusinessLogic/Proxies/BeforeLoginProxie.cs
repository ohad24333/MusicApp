using MusicApp.Entities;
using MusicApp.Entities.Models;

namespace MusicApp.BusinessLogic
{
    public class BeforeLoginProxie : IBeforeLogin
    {
        private AppManagement appManagement = new AppManagement();

        public UserPermissionLevelEnum CheckUserPermissionLevel(User user)
        {
            return appManagement.CheckUserPermissionLevel(user);
        }

        public User SearchUser(string email)
        {
            return appManagement.SearchUser(email);
        }
    }
}
