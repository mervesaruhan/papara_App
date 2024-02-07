using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Shared;
using System.Net.Http.Headers;

namespace papara_firstweek_hwApp.API.Models.Users
{
    public interface IUserService
    {
        ResponseDto<List<UserDto>> GetAll();
        ResponseDto<int> Add(UserAddDtoRequest request);
        void Update(UserUpdateDtoRequest request);
        void Delete(int id);
        UserDto GetById(int id);
    }
}


