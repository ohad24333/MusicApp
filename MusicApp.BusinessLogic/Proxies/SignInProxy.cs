using MusicApp.Entities.Models;

namespace MusicApp.BusinessLogic
{
    public class SignInProxy : ISignIn
    {
        AppManagement _appManagement = new AppManagement();
        public void CheckSignInCollumnsValidilty(User user)
        {
            _appManagement.CheckSignInCollumnsValidilty(user);
        }
    }
}
