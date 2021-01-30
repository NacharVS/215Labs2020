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
        [BsonElement("Imya")]
        public string name;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public int diameter;
        [BsonIgnoreIfDefault]
        public int distance;
        [BsonIgnoreIfDefault]
        public int fit;
    }
    private static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var datebase = client.GetDatabase("galactica");
        var collection = datebase.GetCollection<BsonDocument>("Planet");
        var plat = new BsonDocument();
        var plats = await collection.Find(plat).ToListAsync();

        foreach (var item in plats)
        {
            Console.WriteLine(item);
        }
    }
    private static async Task MongoInsert(Planeta planetaa)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var datebase = client.GetDatabase("galactica");
        var collection = datebase.GetCollection<Planeta>("Planeta");
        await collection.InsertOneAsync(planetaa);
    }
    public static void Run()
    {
        MongoConnect().GetAwaiter().GetResult();
        Planeta earth = new Planeta { name = "Земля ", diameter = 234325, age = 2545, distance = 252525, fit = 23 };
    }
}
