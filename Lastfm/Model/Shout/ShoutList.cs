﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class ShoutList : LastfmBase
    {
        public int total { get; set; }
        public List<Shout> shouts { get; set; }
    }
}