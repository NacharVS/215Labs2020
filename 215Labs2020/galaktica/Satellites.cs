using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.galaktica
{
    class Satellites
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string Name;
        [BsonIgnoreIfDefault]
        public bool Artificial;
        [BsonIgnoreIfDefault]
        public int Age;
        [BsonIgnoreIfDefault]
        public double Temperature;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<BsonDocument>("Satellites");
            var plat = new BsonDocument();
            var plats = await collection.Find(plat).ToListAsync();
        }
        private static async Task MongoInsert(Satellites satel)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<Satellites>("Satellites");
            await collection.InsertOneAsync(satel);
        }
        private static async Task MongoUpdate(string SerachByName, int newAge)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("galactica");
            var collection = datebase.GetCollection<Satellites>("Planeta");
            var update = Builders<Satellites>.Update.Set(a => a.Age, newAge);
            await collection.UpdateOneAsync(std => std.Name == SerachByName, update);
        }
        public static async Task MongoReplaceByName(string SerachByName, Satellites new_satel)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<Satellites>("Satellites");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_satel);
        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Satellites moon = new Satellites() { Name = "Луна", Artificial = false, Age = 4700, Temperature = 20425 };
            MongoInsert(moon).GetAwaiter().GetResult();
            //MongoReplaceByName("Луна", new  Satellites() { Name = "Фобос" }).GetAwaiter().GetResult();
            //MongoUpdate("Луна", 5633).GetAwaiter().GetResult();
        }
    }
   
}
