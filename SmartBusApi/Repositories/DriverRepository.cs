using MongoDB.Bson;
using MongoDB.Driver;
using SmartBusApi.Collections;
using SmartBusApi.Enuns;
using SmartBusApi.MongoDb;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Repositories
{
    public class DriverRepository
    {
        private readonly MongoDbConnector _connector;

        public DriverRepository()
        {
            _connector = new();
        }

        public async Task<List<Driver>> Get()
        {
            return await _connector.Drivers.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<Driver> GetById(string id)
        {
            return await _connector.Drivers.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Driver driver)
        {
            await _connector.Drivers.InsertOneAsync(driver);
        }

        public async Task Update(string id)
        {
            FilterDefinitionBuilder<Driver> builderFilter = Builders<Driver>.Filter;

            FilterDefinition<Driver> filter = builderFilter.Eq(x => x.Id, id);

            UpdateDefinitionBuilder<Driver> definitionBuilder = Builders<Driver>.Update;

            UpdateDefinition<Driver> definition = definitionBuilder.Set(x => x.CnhType, ECnhType.E);

            await _connector.Drivers.FindOneAndUpdateAsync(filter, definition);
        }

        public async Task Delete(string id)
        {
            await _connector.Drivers.DeleteOneAsync(x => x.Id == id);
        }
    }
}
