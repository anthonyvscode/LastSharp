using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Event : LastfmBase
    {
        public string id { get; set; }
        public string title { get; set; }
        public EventArtistList artists { get; set; }
        public Venue venue { get; set; }
        public DateTime startDate { get; set; }
        public string description { get; set; }
        public ImageListMini image { get; set; }
        //TODO: IMAGES GO HERE
        public int attendance { get; set; }
        public int reviews { get; set; }
        public string tag { get; set; }
        public string url { get; set; }
        public string headliner { get; set; }
        public List<Ticket> tickets { get; set; } //TODO: fix tickets
        public int cancelled { get; set; }
    }

    public class EventArtistList : List<artist>
    {
    }

    public class artist
    {
        public string Value { get; set; }
    }
}
