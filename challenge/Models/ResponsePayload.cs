using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenge.Models
{
    public class ResponsePayload
    {
        public string Image { set; get; }
        public string Slug { get; set; }
        public string Title { get; set; }
    }
}