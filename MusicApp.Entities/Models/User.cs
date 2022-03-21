using System.Collections.Generic;

#nullable disable

namespace MusicApp.Entities.Models
{
    public partial class User
    {
        public User()
        {
            ArtistsUsers = new HashSet<ArtistsUser>();
            UserListeningHistory = new HashSet<SongPlayedLog>();
            SongsUsers = new HashSet<SongsUser>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PlayedNowId { get; set; }
        public int PermissionLevel { get; set; }
        public virtual ICollection<ArtistsUser> ArtistsUsers { get; set; }
        public virtual ICollection<SongPlayedLog> UserListeningHistory { get; set; }
        public virtual ICollection<SongsUser> SongsUsers { get; set; }
    }
}
