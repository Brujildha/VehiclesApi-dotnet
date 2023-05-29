using System;
using Microsoft.EntityFrameworkCore;
using vehiclesApi.Data;
using vehiclesApi.Models;

namespace vehiclesApi.Services
{
	public class VehicleService: IVehicleService
    {
        private readonly AppDbContext _db;
        public VehicleService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Vehicle> AddVehicleAsync(Vehicle vehicle)
        {
            try
            {
                await _db.Vehicles.AddAsync(vehicle);
                await _db.SaveChangesAsync();
                return await _db.Vehicles.FindAsync(vehicle.Id);
            }
            catch (Exception ex)
            {
                return null; // An error occured
            }
        }

        public async Task<List<Vehicle>> GetVehiclesAsync()
        {
            var VehicleTypeId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd");
            try
            {
                return await _db.Vehicles.Where(vehicle=>
                vehicle.Available==true &&
                vehicle.Price > 5000 &&
                vehicle.VehicleTypeId!= VehicleTypeId
                ).Include(b=> b.VehicleType).ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<VehicleType>> GetVehiclesTypeAsync()
        {
            try
            {
                return await _db.VehiclesType.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

