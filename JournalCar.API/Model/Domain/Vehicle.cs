namespace JournalCar.API.Model.Domain
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public Guid TypeVehicleId { get; set; }
        public Guid UserId { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Reference { get; set; }


        // Navegation properties
        public TypeVehicle TypeVehicle { get; set; }
        public Users User { get; set; }

    }
}
