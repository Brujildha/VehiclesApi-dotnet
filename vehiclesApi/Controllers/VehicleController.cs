using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vehiclesApi.Models;
using vehiclesApi.Services;

namespace vehiclesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/Vehicle
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicles = await _vehicleService.GetVehiclesAsync();
            if (vehicles == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No vehicles in database");
            }

            return StatusCode(StatusCodes.Status200OK, vehicles);

        }

        // POST: api/Vehicle
        [HttpPost]
        public async Task<ActionResult<Vehicle>> AddVehicle(Vehicle vehicle)
        {
            var dbVehicle = await _vehicleService.AddVehicleAsync(vehicle);

            if (dbVehicle == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{vehicle.Description} could not be added.");
            }
            return StatusCode(StatusCodes.Status200OK, vehicle);
            

        }
        
    }
}
