using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Lastfm.Model
{
    public class Event
    {
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }
        [DeserializeAs(Name = "artists")]
        public EventArtistList Artists { get; set; }
        [DeserializeAs(Name = "venue")]
        public Venue Venue { get; set; }
        [DeserializeAs(Name = "startDate")]
        public DateTime StartDate { get; set; }
        [DeserializeAs(Name = "description")]
        public string Description { get; set; }
        [DeserializeAs(Name = "image")]
        public ImageListMini Image { get; set; }
        //TODO: IMAGES GO HERE
        [DeserializeAs(Name = "attendance")]
        public int Attendance { get; set; }
        [DeserializeAs(Name = "reviews")]
        public int Reviews { get; set; }
        [DeserializeAs(Name = "tag")]
        public string Tag { get; set; }
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
        [DeserializeAs(Name = "headliner")] // some reason this 1 is case sensative...?
        public string Headliner { get; set; }
        //public List<Ticket> Tickets { get; set; } //TODO: fix tickets
        [DeserializeAs(Name = "cancelled")]
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
