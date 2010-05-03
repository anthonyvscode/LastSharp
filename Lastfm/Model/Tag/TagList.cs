﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class TagList
    {
        public string artist { get; set; }
        public List<Tag> tags { get; set; }
    }

    public class TopTagList
    {
        public string artist { get; set; }
        public List<ArtistTag> toptags { get; set; }
    }
}
