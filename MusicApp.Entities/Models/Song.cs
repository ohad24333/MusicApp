using System;
using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Song 
    {
        public Song()
        {
            SongsUsers = new HashSet<SongsUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int Watched { get; set; }

        public DateTime Duration { get; set; }
        public int? PublisherId { get; set; }
        public DateTime DatePublished { get; set; }
        public int? AlbumId { get; set; }
        public int? GenreId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<SongsUser> SongsUsers { get; set; }

      
    }
}
