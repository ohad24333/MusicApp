namespace MusicApp.BusinessLogic
{
    public class ForgotPasswardProxy : IForgotPassward
    {
        AppManagement _appManagement = new AppManagement();
        public void SendEmailWithPassward(string email)
        {
            _appManagement.SendEmailWithPassward(email);
        }
    }
}
