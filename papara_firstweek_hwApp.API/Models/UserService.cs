using papara_firstweek_hwApp.API.Models.DTOs;

namespace papara_firstweek_hwApp.API.Models
{
    public class UserService(IUserRepository userRepository): IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;


        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public int Add(UserAddDtoRequest request)
        {
            var id  =new Random().Next(1,1000);
            var user = new User
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age,
            };
            userRepository.Add(user);
            return user.Id;
        }
    }
}
