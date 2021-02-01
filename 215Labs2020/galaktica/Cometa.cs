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
    class Cometa
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string Name;
        [BsonIgnoreIfDefault]
        public double Speed;
        [BsonIgnoreIfDefault]
        public double Size;
        [BsonIgnoreIfDefault]
        public int Tail_length;
        [BsonIgnoreIfDefault]
        public double Temperature;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<BsonDocument>("Cometa");
            var plat = new BsonDocument();
            var plats = await collection.Find(plat).ToListAsync();
        }
        private static async Task MongoInsert(Cometa comt)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<Cometa>("Cometa");
            await collection.InsertOneAsync(comt);

        }
        public static async Task MongoReplaceByName(string SerachByName, Cometa new_comt)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<Cometa>("Cometa");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_comt);

        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Cometa mrkos = new Cometa() { Name = "Мркос", Size = 100, Speed = 3, Tail_length = 187, Temperature = 30 };
            MongoInsert(mrkos).GetAwaiter().GetResult();
            //MongoReplaceByName("Мркос", new  Cometa() { Name = " Меллиш" }).GetAwaiter().GetResult();

        }
    }
   
}

