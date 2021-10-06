using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SmartBusApi.Enuns;

namespace SmartBusApi.Collections
{
    public class Vehicle
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Model { get; set; }

        public string Plate { get; set; }

        public EVehicleCategory Category { get; set; }
    }
}
