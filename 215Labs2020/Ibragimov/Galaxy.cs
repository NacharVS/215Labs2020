using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _215Labs2020.Ibragimov
{
    class Planet
    {

        [BsonElement("имя")]
        public string name;
        [BsonElement("диаметр")]
        [BsonIgnoreIfDefault]
        public double diameter;
        [BsonElement("температура")]
        [BsonIgnoreIfDefault]
        public int temperature;
        [BsonElement("Дистанция от солнца ")]
        [BsonIgnoreIfDefault]
        public double toSun;
        [BsonElement("Возвраст")]
        public double age;
        [BsonElement("Годность для жизни ")]
        [BsonIgnoreIfDefault]
        public bool fitLie;
        [BsonElement("Speed")]
        [BsonIgnoreIfDefault]
        public double speed;



        static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215");
            var collection = database.GetCollection<BsonDocument>(".лЮБОЕЧТОХОЧЕШЬ");
            var planet = new BsonDocument();
            var universal = await collection.Find(planet).ToListAsync();
            foreach (var item in universal)
            {
                Console.WriteLine(item);
            }
        }
    }
}

