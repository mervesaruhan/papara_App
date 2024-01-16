using papara_firstweek_hwApp.API.Models.DTOs;

namespace papara_firstweek_hwApp.API.Models
{
    public interface IUserService
    {
        List<User> GetAll();
        int Add(UserAddDtoRequest request);
    }
}
