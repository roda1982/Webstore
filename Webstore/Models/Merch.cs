using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webstore.Models
{
    public class Merch : Product
    {
        public string Name { get; set; }
        public Size Size { get; set; }
    }
}