using SongTest.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SongTest.MVC.DAL
{
    public class SongTestContext : DbContext
    {

        public SongTestContext() : base("SongTestContext")
        {
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}