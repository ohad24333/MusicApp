using System;
using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime DayOfFounding { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
