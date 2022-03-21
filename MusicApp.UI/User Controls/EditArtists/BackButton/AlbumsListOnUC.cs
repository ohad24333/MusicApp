namespace MusicApp.UI.User_Controls.EditArtists.BackButton
{
    public class AlbumsListOnUC : IListOnState
    {
        public IListOnState BackButtonPressed(EditArtistsUC editArtistsUC)
        {
            editArtistsUC.OnArtistFound(editArtistsUC.Artists);
            editArtistsUC.MakeBackButtonUnvisible();
            return new ArtistsListOnUC();
        }
    }


}
