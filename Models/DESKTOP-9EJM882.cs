using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class DESKTOP_9EJM882 : DbContext
    {
        public DESKTOP_9EJM882() : base("name=MyDbConnection")
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Personne> Personnes { get; set; }

    }
}