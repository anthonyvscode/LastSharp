using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public abstract class LastfmBase
    {
        public string status { get; set; }
        public Error error { get; set; }
        public bool IsValid
        {
            get
            {
                if (status == "ok")
                    return true;
                else if (status == "failed")
                    return false;
                return false;
            }
        }
    }

    public class Error
    {
        public string Value { get; set; }
        public int code { get; set; }
    }
}
