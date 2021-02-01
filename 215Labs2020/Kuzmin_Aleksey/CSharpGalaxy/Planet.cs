using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;

namespace _215Labs2020.Kuzmin_Aleksey.Galaxy
{
    class Planet
    {
        [BsonId]
        public ObjectId _id;
        [BsonElement("name")]
        public string name;
        [BsonElement("diametr")]
        public double diameter;
        [BsonElement("age")]
        public double age;
        [BsonElement("life")]
        public bool life;
        [BsonElement("distance")]
        public double distance;
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CSharpGalaxy");
            var collection = database.GetCollection<BsonDocument>("Planet");
            var planet = new BsonDocument();
            var Planet = await collection.Find(planet).ToListAsync();
        }
        public static async Task MongoInsert(Planet planet)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Planet>("CSharpGalaxy");
            await collection.InsertOneAsync(planet);
        }
        public static void Program()
        {
            MongoConnect().GetAwaiter().GetResult();
            Planet Mercury = new Planet { name = "Mercury", age = 4.503, life = false, diameter = 4.87, distance = 0.387 };
            Planet Venus = new Planet { name = "Venus", age = 4.503, life = false, diameter = 12.1, distance = 0.723 };
            Planet Earth = new Planet { name = "Earth", age = 4.503, life = true, diameter = 12.756, distance = 1 };
            Planet Mars = new Planet { name = "Mars", age = 4.603, life = false, diameter = 6.67, distance = 1.52 };
            MongoInsert(Mercury).GetAwaiter().GetResult();
            MongoInsert(Venus).GetAwaiter().GetResult();
            MongoInsert(Earth).GetAwaiter().GetResult();
        }
    }
}