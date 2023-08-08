using JournalCar.API.Model.DTOs;

namespace JournalCar.API.Domain
{
    public interface IUserDomain
    {
        Task<List<UserDTO>> GetAll();
        Task<UserDTO?> Get(Guid id);
        Task<UserDTO> Create(UserRegisterRequestDTO user);
        Task<bool> Deactivate(Guid id);
        Task<UserDTO?> Update(Guid id, UserUpdateRequestDTO user);
    }
}
