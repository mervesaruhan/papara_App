using AutoMapper;
using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Users;
using System.Security.Cryptography.X509Certificates;

namespace papara_firstweek_hwApp.API.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
