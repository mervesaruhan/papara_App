using papara_firstweek_hwApp.API.Models.DTOs;

namespace papara_firstweek_hwApp.API.Models
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        int Add(UserAddDtoRequest request);
        void Update(UserUpdateDtoRequest request);   
        void Delete(int id);
    }
}
