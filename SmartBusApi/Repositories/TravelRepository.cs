using MongoDB.Bson;
using MongoDB.Driver;
using SmartBusApi.Collections;
using SmartBusApi.MongoDb;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Repositories
{
    public class TravelRepository
    {
        private readonly MongoDbConnector _connector;

        public TravelRepository()
        {
            _connector = new();
        }

        public async Task<List<Travel>> Get()
        {
            List<Travel> travels = await _connector.Travels.Find(new BsonDocument()).ToListAsync();

            return travels;
        }

        public async Task Add()
        {
            Travel travel = new()
            {
                Origin = "São Paulo",
                Destiny = "Rio de Janeiro",
                Rate = 8
            };

            await _connector.Travels.InsertOneAsync(travel);
        }
   
        public async Task Update(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
