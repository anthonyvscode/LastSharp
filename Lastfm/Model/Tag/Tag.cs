using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Tag
    {
        public string tag {get; set;}
    }

    public class ArtistTag
    {
        public string name { get; set; }
        public string url { get; set; }
        public int count { get; set; }
    }
}
