using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class Artist
    {
        [SerializeAs(Name = "name")]
        public string Name { get; set; }
        [SerializeAs(Name = "mbid")]
        public string MusicBrainzID { get; set; }
        [SerializeAs(Name = "url")]
        public string Url { get; set; }
        //TODO: images.
        public int streamable { get; set; }
        public List<ArtistMini> similar { get; set; }
        public List<ArtistTag> tags { get; set; }
        [SerializeAs(Name = "bio")]
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
