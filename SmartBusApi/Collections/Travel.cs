using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SmartBusApi.Collections
{
    public class Travel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int Rate { get; set; }

        public string Origin { get; set; }

        public string Destiny { get; set; }
    }
}
