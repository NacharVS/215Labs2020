using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
namespace _215Labs2020.Hasanov.Galaxy
{
    class Sattelite
    {
        [BsonIgnoreIfDefault]
        [BsonElement("Название")]
        public string name;
        [BsonElement("Диаметр")]
        public int diametr;
        [BsonElement("Возраст")]
        [BsonIgnoreIfDefault]
        public int age;
        [BsonElement("Искусственный или нет")]
        [BsonIgnoreIfDefault]
        public bool real;
        [BsonElement("Температура")]
        [BsonIgnoreIfDefault]
        public int temp;

        static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<BsonDocument>("Спутники");
            var sattelite = new BsonDocument();
            var sattelites = await collection.Find(sattelite).ToListAsync();

            foreach (var item in sattelites)
            {
                Console.WriteLine(item);
            }
        }
        static async Task MongoInsert(Sattelite sattelite)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Sattelite>("Спутники");
            await collection.InsertOneAsync(sattelite);
        }
        public static async Task Update(sring searchbyname, int newage)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Comets>("Спутники");
            var update = Builders<Comet>.Update.Set(a => a.age, newAge);
            await collection.UpdateOneAsync(std => std.name == searchName, update);
        }
        static async Task PReplaceByName(string searchbyname, Sattelite newsat)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215GalaxyDB");
            var collection = database.GetCollection<Sattelite>("Спутники");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newsat);
        }
        public static void StartGalaxy()
        {
            MongoConnect().GetAwaiter().GetResult();
            Sattelite fobos = new Sattelite { name = "Фобос", diametr = 3000, age = 2500000, temp = 400, real = true };
            MongoInsert(fobos).GetAwaiter().GetResult();
        }
    }
}