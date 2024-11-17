using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patikafy
{
    public class Artists
    {
        public string ArtistName { get; set; }
        public string MusicType { get; set; }
        public int MusicYear { get; set; }
        public int AlbumSales { get; set; }

        public Artists(string artistName, string musicType, int musicYear, int albumSales)
        {
            ArtistName = artistName;
            MusicType = musicType;
            MusicYear = musicYear;
            AlbumSales = albumSales;
        }
    }
}