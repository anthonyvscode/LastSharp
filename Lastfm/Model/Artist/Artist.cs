using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace Lastfm.Model
{
    public class Artist
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
        [DeserializeAs(Name = "mbid")]
        public string MusicBrainzID { get; set; }
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
        //TODO: images.

        [DeserializeAs(Name = "streamable")]
        public int Streamable { get; set; }
        [DeserializeAs(Name = "similar")]
        public List<ArtistMini> similar { get; set; } //TODO: Rename this when DK fixes his bug.
        public List<ArtistTag> Tags { get; set; }
        [DeserializeAs(Name = "bio")]
        public Bio Bio { get; set; }
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
