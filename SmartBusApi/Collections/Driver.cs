using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SmartBusApi.Enuns;

namespace SmartBusApi.Collections
{
    public class Driver
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Cnh { get; set; }

        public ECnhType CnhType { get; set; }
    }
}
