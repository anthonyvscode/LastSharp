using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Artist : LastfmBase
    {

        public string name { get; set; }
        public Guid mbid { get; set; }
        public string url { get; set; }
        //TODO: images.
        public int streamable { get; set; }
        public List<ArtistMini> similar { get; set; }
        public List<ArtistTag> tags { get; set; }
        public Bio bio { get; set; }
    }

    public class Stats
    {
        public int listeners { get; set; }
        public string plays { get; set; }
    }
    public class Bio
    {
        public DateTime published { get; set; }
        public string summary { get; set; }
        public string content { get; set; }
    }
}
