using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
namespace _215Labs2020.Hasanov.Galaxy
{
    class Comets
    {
       
        [BsonElement("Имя")]
        public string name;
        [BsonIgnoreIfDefault]
        [BsonElement("Скорость")]
        public int speed;
        [BsonIgnoreIfDefault]
        [BsonElement("Температура")]
        public int temp;
        [BsonIgnoreIfDefault]
        [BsonElement("Длина хвоста")]
        public int tail;

        static async Task MongoInsert(Comets comet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Comets>("Кометы");
            await collection.InsertOneAsync(comet);
        }
        static async Task MongoConnect()
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<BsonDocument>("Кометы");
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
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Comets>("Кометы");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newcomet);
        }
        public static async Task Update(sring searchbyname, int newage)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Comets>("Кометы");
            var update = Builders<Comet>.Update.Set(a => a.age, newAge);
            await collection.UpdateOneAsync(std => std.name == searchName, update);
        }
        

        public static void StartGalaxy()
        {
            MongoConnect().GetAwaiter().GetResult();
            Comets Lovinus = new Comets { name = "Ловинус", speed = 300, tail = 25, temp = 400 };
            MongoInsert(Lovinus).GetAwaiter().GetResult();
            Update(Lovinus, 500).GetAwaiter().GetResult();
        }
    }
}