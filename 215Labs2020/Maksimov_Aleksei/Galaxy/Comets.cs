using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
namespace _215Labs2020.Maksimov_Aleksei.Galaxy
{
    class Comets
    {
        [BsonId]
        [BsonElement("Id")]
        public int id;
        [BsonElement("name")]
        public string name;
        [BsonIgnoreIfDefault]
        [BsonElement("Speed")]
        public int speed;
        [BsonIgnoreIfDefault]
        [BsonElement("Temperature")]
        public int temp;
        [BsonIgnoreIfDefault]
        [BsonElement("Tail of lenght")]
        public int tail;

        static async Task MongoInsert(Comets comet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<Comets>("planets");
            await collection.InsertOneAsync(comet);
        }
        static async Task MongoConnect()
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<BsonDocument>("comets");
            var planet = new BsonDocument();
            var planets = await collection.Find(planet).ToListAsync();

            foreach (var item in planets)
            {
                Console.WriteLine(item);
            }
        }
        static async Task PReplaceByName(string searchbyname, Comets newcomet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<Comets>("comets");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newcomet);
        }
        public static void StartGalaxy()
        {
            MongoConnect().GetAwaiter().GetResult();
            Comets aue = new Comets { name = "aue", speed = 300, tail = 25, temp = 400 };
        }
    }
}