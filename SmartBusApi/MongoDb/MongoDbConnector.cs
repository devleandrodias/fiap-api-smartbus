using MongoDB.Driver;
using SmartBusApi.Collections;

namespace SmartBusApi.MongoDb
{
    public class MongoDbConnector
    {
        public const string STRING_CONNECTION = "mongodb://balta:e296cd9f@localhost:27017/admin";
        public const string DATABASE = "smart_bus";

        public const string COLLECTION_DRIVER = "drivers";
        public const string COLLECTION_TRAVEL = "travels";
        public const string COLLECTION_VEHICLE = "vehicles";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbConnector()
        {
            _client = new MongoClient(STRING_CONNECTION);
            _database = _client.GetDatabase(DATABASE);
        }

        public IMongoClient Client { get { return _client; } }

        public IMongoCollection<Travel> Travels => _database.GetCollection<Travel>(COLLECTION_TRAVEL);

        public IMongoCollection<Driver> Drivers => _database.GetCollection<Driver>(COLLECTION_DRIVER);

        public IMongoCollection<Vehicle> Vehicles => _database.GetCollection<Vehicle>(COLLECTION_VEHICLE);
    }
}
