using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace _215Labs2020.Maksimov_Aleksei.Galaxy
{
    class planets
    {
        
        [BsonElement("Name")]
        public string name;
        [BsonElement("Diametr")]
        public int diametr;
        [BsonElement("age")]
        [BsonIgnoreIfDefault]
        public int age;
        [BsonElement("life")]
        [BsonIgnoreIfDefault]
        public bool life;
        [BsonElement("distance")]
        [BsonIgnoreIfDefault]
        public int distance;
        [BsonElement("temperature")]
        [BsonIgnoreIfDefault]
        public int temp;

        static async Task MongoConnect()
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<BsonDocument>("planets");
            var planet = new BsonDocument();
            var planets = await collection.Find(planet).ToListAsync();

            foreach (var item in planets)
            {
                Console.WriteLine(item);
            }
        }
        static async Task MongoInsert(planets planet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<planets>("planets");
            await collection.InsertOneAsync(planet);
        }
        static async Task PReplaceByName(string searchbyname, planets newplanet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<planets>("planets");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newplanet);
        }
    }
}
