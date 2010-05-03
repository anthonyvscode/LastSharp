using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Album : LastfmBase
    {
        public int rank { get; set; }
        public string name { get; set; }
        public int playcount { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public ArtistMini artist { get; set; }
        //TODO: images.
    }
}
