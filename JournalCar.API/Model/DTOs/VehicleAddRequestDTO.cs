using JournalCar.API.Model.Domain;
using System.ComponentModel.DataAnnotations;

namespace JournalCar.API.Model.DTOs
{
    public class VehicleAddRequestDTO
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Reference { get; set; }
    }
}
