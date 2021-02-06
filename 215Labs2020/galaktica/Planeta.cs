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
    class Planeta
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Imya")]
        public string name;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public int diameter;
        [BsonIgnoreIfDefault]
        public int distance;
        [BsonIgnoreIfDefault]
        public bool suitable;
        [BsonIgnoreIfDefault]
        public double Temperature;
        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("galactica");
            var collection = datebase.GetCollection<BsonDocument>("Planet");
            var plat = new BsonDocument();
            var plats = await collection.Find(plat).ToListAsync();

            //foreach (var item in plats)
            //{
            //    Console.WriteLine(item);
            //}
        }
        private static async Task MongoInsert(Planeta planetaa)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("galactica");
            var collection = datebase.GetCollection<Planeta>("Planeta");
            await collection.InsertOneAsync(planetaa);
        }
        private static async Task MongoUpdate(string SerachByName, int newage)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("galactica");
            var collection = datebase.GetCollection<Planeta>("Planeta");
            var update = Builders<Planeta>.Update.Set(a => a.age, newage);
            await collection.UpdateOneAsync(std => std.name == SerachByName, update);
        }
        private static async Task MongoDeleteByName(string SerachByName, int diameter)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("galactica");
            var collection = datebase.GetCollection<Planeta>("Planeta");
            await collection.DeleteOneAsync(std => std.name == SerachByName || std.diameter == diameter);
            //await collection.DeleteManyAsync(std => std.name == SerachByName || std.diameter == diameter);
        }
        public static async Task MongoReplaceByName(string SerachByName, Planeta new_planeta)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("galactica");
            var collection = database.GetCollection<Planeta>("Planeta");
            await collection.ReplaceOneAsync(std => std.name == SerachByName, new_planeta);
        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Planeta earth = new Planeta { name = "Земля", diameter = 2325, age = 25, distance = 25, suitable = true, Temperature = 33 };
            Planeta mercury = new Planeta { name = "Меркурий", diameter = 44363, age = 475, distance = 58, suitable = false, Temperature = 42786 };
            Planeta mars = new Planeta { name = "Марс", diameter = 67353, age = 4533, distance = 228345, suitable = true, Temperature = 56536 };
            Planeta venus = new Planeta { name = "Венера", diameter = 121353, age = 34633, distance = 1084234, suitable = false, Temperature = 470436 };
            Planeta jupiter = new Planeta { name = "Юпитер", diameter = 33143884, age = 5344, distance = 75433, suitable = false, Temperature = 20425 };
            Planeta saturn = new Planeta { name = "Сатурн", diameter = 120860353, age = 4634, distance = 1400433, suitable = false, Temperature = -13043 };
            Planeta neptune = new Planeta { name = "Нептун", diameter = 49500356, age = 43436, distance = 4500, suitable = false, Temperature = -20143 };
            Planeta uranus = new Planeta { name = "Уран", diameter = 50720323, age = 4363, distance = 2871, suitable = false, Temperature = -22034 };
            MongoInsert(earth).GetAwaiter().GetResult();
            MongoInsert(mercury).GetAwaiter().GetResult();
            MongoInsert(venus).GetAwaiter().GetResult();
            MongoInsert(mars).GetAwaiter().GetResult();
            MongoInsert(jupiter).GetAwaiter().GetResult();
            MongoInsert(saturn).GetAwaiter().GetResult();
            MongoInsert(neptune).GetAwaiter().GetResult();
            MongoInsert(uranus).GetAwaiter().GetResult();
            //MongoReplaceByName("Земля", new Planeta() { name = "Грязь" }).GetAwaiter().GetResult();
            //MongoUpdate("Марс", 24).GetAwaiter().GetResult();
            //MongoDeleteByName("Земля", 36352).GetAwaiter().GetResult();
            //MongoDeleteByName("Меркурий", 36332).GetAwaiter().GetResult();
            //MongoDeleteByName("Марс", 3635632).GetAwaiter().GetResult();
            //MongoDeleteByName("Венера", 3635).GetAwaiter().GetResult();
            //MongoDeleteByName("Юпитер", 3635).GetAwaiter().GetResult();
            //MongoDeleteByName("Сатурн", 36356).GetAwaiter().GetResult();
            //MongoDeleteByName("Нептун", 3635).GetAwaiter().GetResult();
            //MongoDeleteByName("Уран", 363).GetAwaiter().GetResult();
        }
    }
   
}