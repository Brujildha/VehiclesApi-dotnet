using System;
using System.ComponentModel.DataAnnotations;

namespace vehiclesApi.Models
{
	public class Vehicle
	{
		[Key]
		public Guid Id { get; set; }
		public string? Description { get; set; }
		public float Price { get; set; }
		public bool Available { get; set; }
        public VehicleType? VehicleType { get; set; }
        public Guid? VehicleTypeId { get; set; }
    }
}

