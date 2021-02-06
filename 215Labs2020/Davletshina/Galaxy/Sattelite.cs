using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace _215Labs2020.Davletshina.Galaxy
{
    class Sattelite
    {

        [BsonElement("Name")]
        public string name;
        [BsonElement("Diametr")]
        public int diametr;
        [BsonElement("age")]
        [BsonIgnoreIfDefault]
        public int age;
        [BsonElement("Artifical or not")]
        [BsonIgnoreIfDefault]
        public bool artif;
        [BsonElement("temperature")]
        [BsonIgnoreIfDefault]
        public int temp;

        static async Task MongoConnect()
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<BsonDocument>("Sattelites");
            var sattelite = new BsonDocument();
            var sattelites = await collection.Find(sattelite).ToListAsync();

            foreach (var item in sattelites)
            {
                Console.WriteLine(item);
            }
        }
        static async Task MongoInsert(Sattelite sattelite)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<Sattelite>("Sattelites");
            await collection.InsertOneAsync(sattelite);
        }
        static async Task PReplaceByName(string searchbyname, Sattelite newSat)
        {
            string connectionString = "mongodb:\\localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215-Galaxy");
            var collection = database.GetCollection<Sattelite>("Sattelites");
            await collection.ReplaceOneAsync(std => std.name == searchbyname, newSat);
        }
        public static void StartGalaxy()
        {
            MongoConnect().GetAwaiter().GetResult();
           // Sattelite aue = new Sattelite { name = "aue", diametr = 300, age = 25, temp = 400, artif = true };///////////////
        }
    }
}
