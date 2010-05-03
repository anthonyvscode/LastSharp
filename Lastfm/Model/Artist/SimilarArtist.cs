using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class SimilarArtist
    {
        public string Name {get;set;}
        public Guid mbid {get;set;} //TODO: make restsharp return Guid.Empty instead of causing an exception.
        public decimal match {get; set;}
        public string url {get; set;}
        //TODO: images
        public int streamable { get; set; }
    }
}
