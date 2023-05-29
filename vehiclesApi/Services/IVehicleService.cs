using System;
using vehiclesApi.Models;

namespace vehiclesApi.Services
{
	public interface IVehicleService
	{
        Task<List<Vehicle>> GetVehiclesAsync();
        Task<Vehicle> AddVehicleAsync(Vehicle vehicle);
        Task<List<VehicleType>> GetVehiclesTypeAsync();

    }
}

