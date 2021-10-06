using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBusApi.Data;
using SmartBusApi.Model;

namespace SmartBusApi.Controllers
{
    [ApiController, Route("v1/company")]
    public class CompanyController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAll([FromServices] ApplicationContext context)
        {
            return await context.Companies.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task Create([FromServices] ApplicationContext context, [FromBody] Company company)
        {
            context.Companies.Add(company);

            await context.SaveChangesAsync();
        }
    }
}
