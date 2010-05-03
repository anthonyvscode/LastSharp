using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class Fan
    {
        public string name {get; set;}
        public string realname { get; set; }
        public string url { get; set; }
        public ImageListMini image { get; set; }
        public string weight { get; set; }
    }
}
