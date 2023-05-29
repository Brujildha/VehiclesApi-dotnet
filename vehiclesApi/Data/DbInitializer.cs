using System;
using Microsoft.EntityFrameworkCore;
using vehiclesApi.Models;

namespace vehiclesApi.Data
{
	public class DbInitializer
	{
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<VehicleType>(a =>
            {
                a.HasData(new VehicleType
                {
                    Id = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                    Name = "Automóviles",  
                });
                a.HasData(new VehicleType
                {
                    Id = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                    Name = "Motocicletas",
                });
                a.HasData(new VehicleType
                {
                    Id = new Guid("150c81c6-2458-466e-907a-2df11325e2b8"),
                    Name = "Camionetas",
                });
            });
            _builder.Entity<Vehicle>(b =>
            {
                b.HasData(new Vehicle
                {
                    Id = new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"),
                    Description = "AUDI Q5 ELITE S TRONIC QUATTRO 2.0T STD/AUT 5PTAS MOD 2015.",
                    Available = true,
                    Price = 300000,
                    VehicleTypeId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59")
                });
                b.HasData(new Vehicle
                {
                    Id = new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"),
                    Description = "NISSAN INFINITI M37 PREMIUM VP QC DVD GPS RA-18 AU MOD 2017. ",
                    Available = true,
                    Price = 190000,
                    VehicleTypeId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59")
                });
                b.HasData(new Vehicle
                {
                    Id = new Guid("bd9f66d9-38db-40dd-bf52-cab3f73ed926"),
                    Description = "Vento Screamer Sportivo MOD 2024.",
                    Available = true,
                    Price = 48999,
                    VehicleTypeId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd")
                });
                b.HasData(new Vehicle
                {
                    Id = new Guid("9d42967b-e48b-4b38-ba76-5cb12d8b18cb"),
                    Description = "Harley Davidson Street 750 Black Motorcycle Model Bike 1/12 by Maisto MOD 2015.",
                    Available = true,
                    Price = 355959,
                    VehicleTypeId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd")
                });
                b.HasData(new Vehicle
                {
                    Id = new Guid("2d099aff-a8ab-4a5c-9551-6fc74952b4e8"),
                    Description = "Suzuki Grand Vitara GLX MOD 2019.",
                    Available = true,
                    Price = 480000,
                    VehicleTypeId = new Guid("150c81c6-2458-466e-907a-2df11325e2b8")
                });
            });
        }
	}
}

