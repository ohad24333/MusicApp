namespace MusicApp.UI.User_Controls.EditArtists.BackButton
{
    public class ListOnContext
    {
        private IListOnState _backButtonState;

        public ListOnContext(IListOnState backButtonState)
        {
            _backButtonState = backButtonState;
        }

        public void BeckButtonPressedRequest(EditArtistsUC editArtists )
        {
            _backButtonState = _backButtonState.BackButtonPressed(editArtists);
        }
    }


}
