using JournalCar.API.Model.Domain;

namespace JournalCar.API.Model.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Id_Number { get; set; }
        public bool IsActive { get; set; }


        public TypeDocDTO TypeDoc { get; set; }
    }
}
