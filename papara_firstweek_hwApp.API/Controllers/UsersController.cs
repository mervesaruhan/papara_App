using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using papara_firstweek_hwApp.API.Models;
using papara_firstweek_hwApp.API.Models.DTOs;

namespace papara_firstweek_hwApp.API.Controllers
{
    /// <summary>
    /// https://localhost:7092/api/users
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        public readonly IUserService userService = new UserService( new UserRepository());

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());

        }

        [HttpPost]
        public IActionResult Add(UserAddDtoRequest request)
        {
            //complex type => request body
            //simple type => request body
            int result = userService.Add(request);
            return Created("", result);
            
        }


        [HttpPut]
        public IActionResult Update()
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return NoContent();
        }

    }
}
