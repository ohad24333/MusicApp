
using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
            ArtistsUsers = new HashSet<ArtistsUser>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string StageName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CoutryId { get; set; }

        public virtual Coutry Coutry { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<ArtistsUser> ArtistsUsers { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
