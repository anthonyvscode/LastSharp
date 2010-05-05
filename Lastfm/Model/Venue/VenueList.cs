using System.Collections.Generic;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class VenueList
    {
        public string Query { get; set; }
        public string TotalResults { get; set; }
        public string StartIndex { get; set; }
        public string ItemsPerPage { get; set; }
        [SerializeAs(Name = "venuematches")]
        public List<Venue> Venues { get; set; }
    }
}
