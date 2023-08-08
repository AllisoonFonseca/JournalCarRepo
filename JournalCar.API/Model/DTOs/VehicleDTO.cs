using JournalCar.API.Model.Domain;

namespace JournalCar.API.Model.DTOs
{
    public class VehicleDTO
    {
        public Guid Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Reference { get; set; }


        // Navegation properties
        public TypeVehicleDTO TypeVehicle { get; set; }
    }
}
