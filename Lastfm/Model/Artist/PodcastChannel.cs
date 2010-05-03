using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class PodcastChannel
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public List<ChannelItem> item { get; set; } //TODO: this is wrong i think...
    }

    public class ChannelItem
    {
        public string title { get; set; }
        public ChannelLink _guid { get; set; }
        public string author { get; set; }
        public Enclosure enclosure {get; set;}
        public string description { get; set; }
        public string link { get; set; }
    }
    public class ChannelLink
    {
        public bool isPermaLink { get; set; }
        public string Value { get; set; }
    }

    public class Enclosure
    {
        public string Value { get; set; }
        public string url { get; set; }
        public string length { get; set; }
        public string type { get; set; }
    }
}
