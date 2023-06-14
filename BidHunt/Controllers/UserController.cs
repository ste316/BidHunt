using BidHunt.Data;
using BidHunt.Migrations;
using BidHunt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BidHunt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApiDbContextcs _dbContext = new ApiDbContextcs();

        [HttpGet]
        public IEnumerable<User> GetAllUser()
        {
            return _dbContext.Users;
        }

        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
