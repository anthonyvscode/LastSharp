using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class FanList : LastfmBase
    {
        public string artist { get; set; }
        public List<Fan> topfans { get; set; }
    }
}