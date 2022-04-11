using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Portfolio.Models.Class
{
    public class Context: DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}