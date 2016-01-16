using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webstore.Models
{
    public class Album : Product
    {
        public string Title { get; set; }
        public List<string> Tracks { get; set; }
        public MediaType MediaType { get; set; }



    }
}