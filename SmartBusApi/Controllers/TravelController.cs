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

        [HttpPut("{id}")]
        public async Task Update()
        {
            return await _repository.Update();
        }

        [HttpDelete("{id}")]
        public async Task Delete()
        {
            return await _repository.Delete();
        }

        [HttpPost]
        public async Task Add()
        {
            await _repository.Add();
        }
    }
}
