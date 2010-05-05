using System;
using System.Collections.Generic;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class Event
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public EventArtistList Artists { get; set; }
        public Venue Venue { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public ImageListMini Image { get; set; }
        //TODO: IMAGES GO HERE
        public int Attendance { get; set; }
        public int Reviews { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
        [SerializeAs(Name = "headliner")] // some reason this 1 is case sensative...?
        public string Headliner { get; set; }
        public List<Ticket> Tickets { get; set; } //TODO: fix tickets
        public int Cancelled { get; set; }
    }

    public class EventArtistList : List<artist>
    {
    }

    public class artist
    {
        public string Value { get; set; }
    }
}
