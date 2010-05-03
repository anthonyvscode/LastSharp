using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class VenueList
    {
        public string query {get; set;}
        public string totalResults { get; set; }
        public string startIndex { get; set; }        
        public string itemsPerPage { get; set; }
        public List<Venue> venuematches { get; set; }
    }
}
