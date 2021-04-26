using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBusApi.Data;
using SmartBusApi.Model;

namespace SmartBusApi.Controllers
{
    [ApiController, Route("v1/user")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll([FromServices] ApplicationContext context)
        {
            return await context.Users.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task Create([FromServices] ApplicationContext context, [FromBody] User user)
        {
            context.Users.Add(user);

            await context.SaveChangesAsync();
        }
    }
}
