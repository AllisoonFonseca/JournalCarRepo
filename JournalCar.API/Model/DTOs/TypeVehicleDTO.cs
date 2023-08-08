using System.ComponentModel.DataAnnotations;

namespace JournalCar.API.Model.DTOs
{
    public class TypeVehicleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? IconUrl { get; set; }
    }
}
