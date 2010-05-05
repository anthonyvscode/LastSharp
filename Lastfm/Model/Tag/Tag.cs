
using RestSharp.Serializers;
namespace Lastfm.Model
{
    public class Tag
    {
        [SerializeAs(Name = "tag")]
        public string Name { get; set; }
    }

    public class ArtistTag
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Count { get; set; }
    }
}
