namespace JournalCar.API.Model.Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Guid CategoryActivityId { get; set; }
        public Guid StatusId { get; set; }


        // Navigation properties
        public CategoryActivity CategoryActivity { get; set; }
        public Status Status { get; set; }
        public Vehicle Vehicle { get; set; }
    
    }
}
