using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace _215Labs2020.Шагимуратова.Galaxy
{
    class Planets
    {
        [BsonElement("Name")]
        public string name;
        [BsonElement("Age")]
        public string age;
        [BsonElement("Diametr")]
        public string diametr;
        [BsonElement("Life")]
        public string life;
        [BsonElement("Distant")]
        public string distant;
        [BsonElement("Temp")]
        public double temp;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<BsonDocument>("Planets");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(Planets pl)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Planets>("Planets");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_pl);
        }
        public static async Task MongoReplaceByName(string SerachByName, Planets new_pl)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Planets>("Planets");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_pl);
        }
        public static void Inform() 
        {
            MongoConnect().GetAwaiter().GetResult();

        }
    }
}
