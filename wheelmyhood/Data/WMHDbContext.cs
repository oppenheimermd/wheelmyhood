using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WheelMyHood.Models;

namespace WheelMyHood.Data
{
    //  https://docs.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-2.1
    public class WmhDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>,Guid>
    {
        public WmhDbContext(DbContextOptions<WmhDbContext> options) : base(options)
        {
            
        }

        /// <summary>
        /// When the database is created, EF creates tables that have names the same as the DbSet
        /// property names. Property names for collections are typically plural.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<PlaceType>().ToTable("PlaceType");
            modelBuilder.Entity<PlacePhoto>().ToTable("PlacePhoto");
            modelBuilder.Entity<Place>().ToTable("Place");
            modelBuilder.Entity<Neighbourhood>().ToTable("Neighbourhood");
            modelBuilder.Entity<City>().ToTable("City");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<PlaceType> PlaceTypes { get; set; }
        public DbSet<PlacePhoto> PlacePhotos { get; set; }
        public DbSet<Place> Placess { get; set; }
        public DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
