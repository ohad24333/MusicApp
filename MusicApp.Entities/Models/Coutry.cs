
using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class Coutry
    {
        public Coutry()
        {
            Artists = new HashSet<Artist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
