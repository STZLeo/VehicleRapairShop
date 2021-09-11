using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<DocumentTypes> DocumentTypes { get; set; }
        public DbSet<Procedures> Procedures { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brands>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<DocumentTypes>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Procedures>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
