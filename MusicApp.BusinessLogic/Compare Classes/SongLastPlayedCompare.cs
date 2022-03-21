﻿using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public class SongLastPlayedCompare : IComparer<SongPlayedLog>
    {
        public int Compare(SongPlayedLog x, SongPlayedLog y)
        {
            return y.TimePlayed.CompareTo(x.TimePlayed);
        }
    }
}
