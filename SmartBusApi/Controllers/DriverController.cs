using Microsoft.AspNetCore.Mvc;
using SmartBusApi.Collections;
using SmartBusApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Controllers
{
    [ApiController, Route("v1/driver")]
    public class DriverController : Controller
    {
        private readonly DriverRepository _repository;

        public DriverController()
        {
            _repository = new();
        }

        [HttpGet]
        public async Task<List<Driver>> Get()
        {
            return await _repository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Driver> GetById([FromRoute] string id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        public async Task Create([FromBody] Driver driver)
        {
            await _repository.Create(driver);
        }

        [HttpPut("{id}")]
        public async Task Update([FromRoute] string id)
        {
            await _repository.Update(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] string id)
        {
            await _repository.Delete(id);
        }
    }
}
