using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Image
    {
        public string title { get; set; }
        public string url { get; set; }
        public DateTime dateadded { get; set; }
        public string format { get; set; }
        public Owner owner {get; set;}
        public List<Size> sizes { get; set; }
        public Votes votes { get; set; }
    }

    public class Owner
    {
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Size
    {
        public string Value { get; set; }
        public string name { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }

    public class Votes
    {
        public int thumbsup { get; set; }
        public int thumbsdown { get; set; }
    }
}
