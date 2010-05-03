using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Location : LastfmBase
    {
        public string city { get; set; }
        public string country { get; set; }
        public string street { get; set; }
        public string postalcode { get; set; }
        public Point point { get; set; }
    }

    public class Point
    {
        public decimal? lat { get; set; }
        public decimal? _long {get; set;}
    }
}