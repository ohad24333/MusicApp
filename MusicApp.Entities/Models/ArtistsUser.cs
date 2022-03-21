
#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class ArtistsUser
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int UserId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual User User { get; set; }
    }
}
