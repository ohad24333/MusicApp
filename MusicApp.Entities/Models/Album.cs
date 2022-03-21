using System;
using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string AlbumName { get; set; }
        public int ArtistId { get; set; }
        public DateTime DatePublished { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
