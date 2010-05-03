using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Venue : LastfmBase
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public string url { get; set; }
        public string website { get; set; }
        public string phonenumber { get; set; }
        public ImageListMini image { get; set; }
    }
}
