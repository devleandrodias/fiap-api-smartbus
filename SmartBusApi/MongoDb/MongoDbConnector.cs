using MongoDB.Driver;
using SmartBusApi.Collections;

namespace SmartBusApi.MongoDb
{
    public class MongoDbConnector
    {
        public const string STRING_CONNECTION = "mongodb://balta:e296cd9f@localhost:27017/admin";
        public const string DATABASE = "smart_bus";

        public const string COLLECTION_TRAVEL = "travels";
        public const string COLLECTION_2 = "books";
        public const string COLLECTION_3 = "books";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbConnector()
        {
            _client = new MongoClient(STRING_CONNECTION);
            _database = _client.GetDatabase(DATABASE);
        }

        public IMongoClient Client { get { return _client; } }

        public IMongoCollection<Travel> Travels
        {
            get
            {
                return _database.GetCollection<Travel>(COLLECTION_TRAVEL);
            }
        }
    }
}
