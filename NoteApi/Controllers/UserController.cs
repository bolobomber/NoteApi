using Microsoft.AspNetCore.Mvc;
using Note.DAL.Models;
using Note.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> AddUser(string name,string email,string password)
        {
           await userService.AddUser(name, email, password);
           return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await userService.DeleteUser(id);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task<User> GetUser(int id)
        {
            return await userService.GetUserById(id);
        }

        [HttpGet("Users")]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await userService.GetAllUsers();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(string name, string email, string password)
        {
            await userService.UpdateUser(name,email,password);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
