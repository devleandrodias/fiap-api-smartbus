using Microsoft.AspNetCore.Mvc;
using SmartBusApi.Collections;
using SmartBusApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Controllers
{
    [ApiController, Route("v1/travel")]
    public class TravelController : Controller
    {
        private readonly TravelRepository _repository;

        public TravelController()
        {
            _repository = new();
        }

        [HttpGet]
        public async Task<ActionResult<List<Travel>>> Get()
        {
            return await _repository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Travel>> GetById([FromRoute()] string id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        public async Task Create([FromBody] Travel travel)
        {
            await _repository.Create(travel);
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
