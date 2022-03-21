using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
