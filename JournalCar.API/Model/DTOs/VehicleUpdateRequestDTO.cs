using System.ComponentModel.DataAnnotations;

namespace JournalCar.API.Model.DTOs
{
    public class VehicleUpdateRequestDTO
    {
        [Required]
        public Guid TypeVehicleId { get; set; }
        [Required]
        public string Plate { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Reference { get; set; }

    }
}
