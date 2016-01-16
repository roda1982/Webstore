using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webstore.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}