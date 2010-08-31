using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace Lastfm.Model
{
    public class ImageList
    {
        public List<Image> images { get; set; }
    }

    public class ImageListMini : List<image>
    {
    }

    public class image
    {
        public string size { get; set; }
        public string Value { get; set; }
    }
}