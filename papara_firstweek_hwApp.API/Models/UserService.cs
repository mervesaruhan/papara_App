using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using papara_firstweek_hwApp.API.Extensions;
using papara_firstweek_hwApp.API.Models.DTOs;
using System.Xml.Linq;

namespace papara_firstweek_hwApp.API.Models
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository userRepository;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
            userRepository = new UserRepository();
        }
        


        public List<UserDto> GetAll()
        {
            List<User> users = userRepository.GetAll();

            List<UserDto>  userDtos = _mapper.Map<List<UserDto>>(users);

            return userDtos;
        }


        public ResponseDto<int> Add(UserAddDtoRequest request)
        {
            var id  =new Random().Next(1,1000);
            var user = new User
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age!.Value,
            };
            userRepository.Add(user);
            return ResponseDto<int>.Success(id);
        }

        public void Update(UserUpdateDtoRequest request)
        {
            User user = new User
            {
                Id = request.Id,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age
            };
            userRepository.Update(user);
        }

        public void Delete(int id)
        {
            userRepository.Delete(id);
        }
    }
}
