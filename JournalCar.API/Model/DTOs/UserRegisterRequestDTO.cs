using JournalCar.API.Model.Domain;
using System.ComponentModel.DataAnnotations;

namespace JournalCar.API.Model.DTOs
{
    public class UserRegisterRequestDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public Guid TypeDocId { get; set; }
        [Required]
        public string Id_Number { get; set; }

    }
}
