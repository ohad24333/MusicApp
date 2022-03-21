using MusicApp.Entities.Models;

namespace MusicApp.BusinessLogic
{
    public interface ISignIn
    {
        public void CheckSignInCollumnsValidilty(User user);
    }
}
