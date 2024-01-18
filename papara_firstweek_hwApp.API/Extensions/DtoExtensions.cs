using papara_firstweek_hwApp.API.Models;
using papara_firstweek_hwApp.API.Models.DTOs;
using System.Collections.Generic;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class DtoExtensions
    {
        public static List<UserDto> ToDtoList(this List<User> users)
        {
            return users.Select(user => new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Age = user.Age
            }).ToList();
        }
    }
}
