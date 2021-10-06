using MongoDB.Bson;
using MongoDB.Driver;
using SmartBusApi.Collections;
using SmartBusApi.MongoDb;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusApi.Repositories
{
    public class VehicleRepository
    {
        private readonly MongoDbConnector _connector;

        public VehicleRepository()
        {
            _connector = new();
        }

        public async Task<List<Vehicle>> Get()
        {
            return await _connector.Vehicles.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<Vehicle> GetById(string id)
        {
            return await _connector.Vehicles.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Vehicle vehicle)
        {
            await _connector.Vehicles.InsertOneAsync(vehicle);
        }

        public async Task Update(string id)
        {
            FilterDefinitionBuilder<Vehicle> builderFilter = Builders<Vehicle>.Filter;

            FilterDefinition<Vehicle> filter = builderFilter.Eq(x => x.Id, id);

            UpdateDefinitionBuilder<Vehicle> definitionBuilder = Builders<Vehicle>.Update;

            UpdateDefinition<Vehicle> definition = definitionBuilder.Set(x => x.Model, "M. Benz Of-1721");

            await _connector.Vehicles.FindOneAndUpdateAsync(filter, definition);
        }

        public async Task Delete(string id)
        {
            await _connector.Vehicles.DeleteOneAsync(x => x.Id == id);
        }
    }
}
