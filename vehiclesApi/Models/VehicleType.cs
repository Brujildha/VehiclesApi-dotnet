using System;
using System.ComponentModel.DataAnnotations;

namespace vehiclesApi.Models
{
	public class VehicleType
	{
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<Vehicle>? Vehicles { get; set; }

    }
}

