using System;
using Microsoft.EntityFrameworkCore;
using vehiclesApi.Models;

namespace vehiclesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } = null!;
        public DbSet<VehicleType> VehiclesType { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vehicle>()
                .HasOne(x => x.VehicleType)
                .WithMany(x => x.Vehicles);

            new DbInitializer(builder).Seed();
        }
    }
}

