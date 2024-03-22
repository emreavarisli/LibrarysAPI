using LibrarysAPI.Data;
using LibrarysAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UsersDbContext dbContext;
        public UsersController(UsersDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await dbContext.Users.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUsers([FromRoute] int id)
        {
            var user = await dbContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers(AddUserRequest addUserRequest)
        {
            var user = new User()
            {
                FullName = addUserRequest.FullName,
                Phone = addUserRequest.Phone,
                Address = addUserRequest.Address,
                EMail = addUserRequest.EMail,
                DateRegistered = addUserRequest.DateRegistered,
                Status = addUserRequest.Status,
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUsers([FromRoute] int id, UpdateUserRequest updateUserRequest)
        {
            var user = await dbContext.Users.FindAsync(id);

            if (user != null)
            {
                user.FullName = updateUserRequest.FullName;
                user.Phone = updateUserRequest.Phone;
                user.Address = updateUserRequest.Address;
                user.EMail = updateUserRequest.EMail;
                user.DateRegistered = updateUserRequest.DateRegistered;
                user.Status = updateUserRequest.Status;

                await dbContext.SaveChangesAsync();

                return Ok(user);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUsers([FromRoute] int id)
        {
            var user = await dbContext.Users.FindAsync(id);

            if (user != null)
            {
                dbContext.Remove(user);
                dbContext.SaveChanges();
                return Ok(user);
            }

            return NotFound();
        }
    }
}
