using System.Collections.Generic;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class TagList
    {
        public string Artist { get; set; }
        public List<Tag> Tags { get; set; }
    }

    public class TopTagList
    {
        public string Artist { get; set; }
        [SerializeAs(Name = "toptags")]
        public List<ArtistTag> Tags { get; set; }
    }
}
