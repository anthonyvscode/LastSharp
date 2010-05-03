using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class EventsList : LastfmBase
    {
        public List<Event> events { get; set; }
    }
}