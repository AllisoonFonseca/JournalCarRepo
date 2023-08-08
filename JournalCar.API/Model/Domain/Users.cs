namespace JournalCar.API.Model.Domain
{
    public class Users
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid TypeDocId { get; set; }
        public string Id_Number { get; set; }
        public bool IsActive { get; set; }


        //Navigation properties
        public TypeDoc TypeDoc { get; set; }

    }
}
