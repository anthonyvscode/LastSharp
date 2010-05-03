using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class SimilarArtistList : LastfmBase
    {
        public int streamable { get; set; }
        public string artist { get; set; }
        public List<SimilarArtist> similarartists { get; set; }
    }
}
