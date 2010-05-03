using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class Location
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public Point Point { get; set; }
    }

    public class Point
    {
        [SerializeAs(Name = "lat")]
        public decimal? Latitude { get; set; }
        [SerializeAs(Name = "_long")]
        public decimal? Longitude {get; set;}
    }
}