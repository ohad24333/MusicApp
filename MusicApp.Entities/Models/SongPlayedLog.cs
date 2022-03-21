using System;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class SongPlayedLog
    {
        public int Id { get; set; }
        public DateTime TimePlayed { get; set; }
        public int SongId { get; set; }
        public int UserId { get; set; }
        public virtual Song Song { get; set; }
        public virtual User User { get; set; }
    }
}
