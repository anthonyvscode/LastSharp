using System.Collections.Generic;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class FanList
    {
        public string Artist { get; set; }
        [SerializeAs(Name = "topfans")]
        public List<Fan> Fans { get; set; }
    }
}