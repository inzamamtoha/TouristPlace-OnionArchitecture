using DataLayer.DbMapping;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class TouristPlaceContext : DbContext
    {
        public TouristPlaceContext(DbContextOptions<TouristPlaceContext> options) : base(options)
        {

        }
        public DbSet<Place> Place { get; set; }
        public DbSet<UserLogIn> UserLogIn { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new UserLogInConfiguration());
        }
    }
}
