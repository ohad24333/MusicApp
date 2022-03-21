namespace MusicApp.UI.User_Controls.EditArtists.BackButton
{
    public class SongsListOnUC : IListOnState
    {
        public IListOnState BackButtonPressed(EditArtistsUC editArtistsUC)
        {
            editArtistsUC.OnBannerClick(editArtistsUC.CurrentSelectedArtist.Id, Enums.TypesEnum.Artist);
            return new AlbumsListOnUC();
        }
    }


}
