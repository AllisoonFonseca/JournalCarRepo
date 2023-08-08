using AutoMapper;
using JournalCar.API.Model.Domain;
using JournalCar.API.Model.DTOs;
using JournalCar.API.Repository.User;
using Microsoft.VisualBasic;

namespace JournalCar.API.Domain
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserDomain(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAll() => 
            mapper.Map<List<UserDTO>>(await userRepository.GetAll());

        public async Task<UserDTO?> Get(Guid id) => 
            mapper.Map<UserDTO>(await userRepository.Get(id));

        public async Task<UserDTO> Create(UserRegisterRequestDTO user)
        {
            var userDomain = mapper.Map<Users>(user);
            userDomain.IsActive = true;

            return mapper.Map<UserDTO>(await userRepository.Register(userDomain));
        }

        public async Task<bool> Deactivate(Guid id)
        {
            var user = await userRepository.Get(id);

            if (user == null) { return false; }

            user.IsActive = false;
            await userRepository.Update();

            return true;
        }

        public async Task<UserDTO?> Update(Guid id, UserUpdateRequestDTO user)
        {
            var userUpdated = await userRepository.Get(id);

            if (userUpdated == null) { return null; }

            userUpdated.FirstName = user.FirstName;
            userUpdated.Surname = user.Surname;
            userUpdated.Email = user.Email;
            userUpdated.Password = user.Password;
            await userRepository.Update();

            return mapper.Map<UserDTO?>(userUpdated);
        }
        
    }
}
