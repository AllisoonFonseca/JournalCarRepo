using AutoMapper;
using JournalCar.API.Model.Domain;
using JournalCar.API.Model.DTOs;

namespace JournalCar.API.Model.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Users, UserRegisterRequestDTO>().ReverseMap();
            CreateMap<Users, UserDTO>().ReverseMap();
            CreateMap<TypeDoc, TypeDocDTO>().ReverseMap();
            CreateMap<Users, UserUpdateRequestDTO>().ReverseMap();
        }
    }
}
