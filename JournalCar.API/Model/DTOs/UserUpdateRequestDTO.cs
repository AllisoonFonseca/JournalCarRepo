using System.ComponentModel.DataAnnotations;

namespace JournalCar.API.Model.DTOs
{
    public class UserUpdateRequestDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
