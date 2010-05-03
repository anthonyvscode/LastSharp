﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;

namespace Lastfm.Model
{
    public class Album
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Playcount { get; set; }

        [SerializeAs(Name = "mbid")]
        public string MusicBrainzID { get; set; }
        public string url { get; set; }
        public ArtistMini artist { get; set; }
        //TODO: images.
    }
}
