using JournalCar.API.Model.Domain;

namespace JournalCar.API.Repository.User
{
    public interface IUserRepository
    {
        Task<List<Users>> GetAll();
        Task<Users?> Get(Guid id);
        Task<Users> Register(Users user);
        Task Update();
    }
}
