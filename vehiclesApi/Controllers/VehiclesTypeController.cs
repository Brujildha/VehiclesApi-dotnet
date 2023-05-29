using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vehiclesApi.Services;

namespace vehiclesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesTypeController : ControllerBase
    {

        private readonly IVehicleService _vehicleService;

        public VehiclesTypeController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: VehiclesType
        [HttpGet]
        public async Task<IActionResult> GetVehiclesType()
        {
            var vehiclesType = await _vehicleService.GetVehiclesTypeAsync();
            if (vehiclesType == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No vehiclesType in database");
            }

            return StatusCode(StatusCodes.Status200OK, vehiclesType);

        }
    }
}