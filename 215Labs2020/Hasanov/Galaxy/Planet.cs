using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace _215Labs2020.Hasanov.Galaxy
{
    class planets
    {

        [BsonElement("Имя")]
        public string name;
        [BsonElement("Диаметр")]
        public int diametr;
        [BsonElement("Возраст")]
        [BsonIgnoreIfDefault]
        public int age;
        [BsonElement("Пригодный для жизни")]
        [BsonIgnoreIfDefault]
        public bool life;
        [BsonElement("Дистанция до Солнца")]
        [BsonIgnoreIfDefault]
        public int distance;
        [BsonElement("Температура")]
        [BsonIgnoreIfDefault]
        public int temp;

        static async Task MongoConnect()
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<BsonDocument>("Планеты");
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
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<planets>("Планеты");
            await collection.InsertOneAsync(planet);
        }
        public static async Task Update(sring searchbyname, int newage)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Comets>("Планеты");
            var update = Builders<Comet>.Update.Set(a => a.age, newAge);
            await collection.UpdateOneAsync(std => std.name == searchName, update);
        }
        static async Task PReplaceByName(string searchbyname, planets newplanet)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<planets>("Планеты");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newplanet);
        }
        public static void StartGalaxy()
        {
            MongoConnect().GetAwaiter().GetResult();
            planets Gorgy = new planets { name = "Джоржи", diametr = 33200, distance = 2425, temp = 4001, life = true, age = 12563321 };
            MongoInsert(Gorgy).GetAwaiter().GetResult();
        }

    }
}