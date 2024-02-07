using AutoMapper;
using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Users
{
    public class UserServiceWithSqlServer(IUserRepository userRepository, IMapper mapper) : IUserService
    {
        private IUserRepository _userRepository = userRepository;
        private IMapper _mapper = mapper;
        public ResponseDto<int> Add(UserAddDtoRequest request)
        {
            var user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age!.Value,
            };
            _userRepository.Add(user);
            return ResponseDto<int>.Success(user.Id);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<List<UserDto>> GetAll()
        {
            var userList = _userRepository.GetAll();
            var userListWithDto = _mapper.Map<List<UserDto>>(userList);
            return ResponseDto<List<UserDto>>.Success(userListWithDto);
        }

        public UserDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserUpdateDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
