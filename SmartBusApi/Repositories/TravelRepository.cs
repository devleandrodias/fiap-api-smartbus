using MongoDB.Bson;
using MongoDB.Driver;
using SmartBusApi.Collections;
using SmartBusApi.MongoDb;
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
            return await _connector.Travels.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<Travel> GetById(string id)
        {
            return await _connector.Travels.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Travel travel)
        {
            await _connector.Travels.InsertOneAsync(travel);
        }

        public async Task Update(string id)
        {
            FilterDefinitionBuilder<Travel> builderFilter = Builders<Travel>.Filter;

            FilterDefinition<Travel> filter = builderFilter.Eq(x => x.Id, id);

            UpdateDefinitionBuilder<Travel> definitionBuilder = Builders<Travel>.Update;

            UpdateDefinition<Travel> definition = definitionBuilder.Set(x => x.Rate, 10);

            await _connector.Travels.FindOneAndUpdateAsync(filter, definition);
        }

        public async Task Delete(string id)
        {
            await _connector.Travels.DeleteOneAsync(x => x.Id == id);
        }
    }
}
