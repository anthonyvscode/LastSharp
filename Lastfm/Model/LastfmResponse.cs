using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Model
{
    public class LastfmResponse<T>
    {
        public T Value { get; set; }
        public string Status { get; set; }
        public Error Error { get; set; }
        public bool IsValid
        {
            get
            {
                if (Status == "ok")
                    return true;
                else if (Status == "failed")
                    return false;
                return false;
            }
        }
    }

    public class Error
    {
        public string Value { get; set; }
        public int Code { get; set; }
    }
}
