using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saas_platform_subcription.Models
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext() : base ("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public static AppDbContext Create ()
        {
            return new AppDbContext();
        }

        public System.Data.Entity.DbSet<Country> Countries { get; set; }
        public System.Data.Entity.DbSet<Region> Regions { get; set; }

    }
}