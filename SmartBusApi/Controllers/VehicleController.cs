using Microsoft.AspNetCore.Mvc;
using SmartBusApi.Collections;
using SmartBusApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Controllers
{
    [ApiController, Route("v1/vehicle")]
    public class VehicleController : Controller
    {
        private readonly VehicleRepository _repository;

        public VehicleController()
        {
            _repository = new();
        }

        [HttpGet]
        public async Task<List<Vehicle>> Get()
        {
            return await _repository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Vehicle> GetById([FromRoute] string id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        public async Task Create([FromBody] Vehicle vehicle)
        {
            await _repository.Create(vehicle);
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
