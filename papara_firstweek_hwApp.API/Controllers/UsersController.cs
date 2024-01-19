using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
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

        private readonly IFileProvider _fileProvider;
        private readonly IUserService userService;
        

        public UsersController(IMapper mapper, IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
            userService = new UserService(mapper);
        }

        [Route("SaveFile")]
        [HttpPost]
        public IActionResult SavePicture(IFormFile file)
        {
            IDirectoryContents pictureDirectory = _fileProvider.GetDirectoryContents("wwwroot");

            IFileInfo pictures = pictureDirectory.Where(x => x.Name == "pictures")!.Single();


            string path = Path.Combine(pictures.PhysicalPath!, file.FileName);

            using FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);

            return Created($"/pictures/{file.FileName}", null);
        }




        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());

        }

        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            //var user = userService.GetById(id);

            //if (user == null)
            //{
                //return NotFound();
            //}
            //return Ok(user);

            return Ok(userService.GetAll());

        }

        [HttpGet("page/{page}/size/{size}")]
        public IActionResult GetProductsWithPaged(int page, int size)
        {
            return Ok(userService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(UserAddDtoRequest request)
        {
            ResponseDto<int> result = userService.Add(request);
            return Created("", result);   
        }


        [HttpPut]
        public IActionResult Update(UserUpdateDtoRequest request)
        {
            userService.Update(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            userService.Delete(id);
            return NoContent();
        }

    }
}
