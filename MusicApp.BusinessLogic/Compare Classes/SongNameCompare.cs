using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public class SongNameCompare : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
