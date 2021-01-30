using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;


namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Planets.Main1();
        }
    }
    class Planets
    {
        [BsonElement("Имя")]
        public string Name;
        [BsonElement("Диаметр (км)")]
        public double Diametr;
        [BsonElement("Возраст (млрд лет)")]
        public double Age;
        [BsonElement("Жизнепригодный?")]
        public bool Livable;
        [BsonElement("Расстояние до Солнца (млн км)")]
        public double Distance;
        [BsonElement("Температура (°С)")]
        public double Temperature;
        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Gallactic");
            var collection = database.GetCollection<BsonDocument>("Planets");
            var user_client = new BsonDocument();
            var user_clients = await collection.Find(user_client).ToListAsync();
        }
        private static async Task MongoInsert(Planets planet)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Gallactic");
            var collection = database.GetCollection<Planets>("Planets");
            await collection.InsertOneAsync(planet);
        }
        public static void Main1()
        {
            MongoConnect().GetAwaiter().GetResult();
            Planets planet1 = new Planets { Name = "Меркурий", Diametr = 4879.4, Age = 4.6, Livable = false, Distance = 58, Temperature = 427 };
            Planets planet2 = new Planets { Name = "Венера", Diametr = 12103.6, Age = 4.6, Livable = false, Distance = 108, Temperature = 470 };
            Planets planet3 = new Planets { Name = "Земля", Diametr = 12742, Age = 4.54, Livable = true, Distance = 149.6, Temperature = 56.7 };
            Planets planet4 = new Planets { Name = "Марс", Diametr = 6739.8, Age = 4.65, Livable = true, Distance = 228, Temperature = 20 };
            Planets planet5 = new Planets { Name = "Юпитер", Diametr = 143884, Age = 5, Livable = false, Distance = 778.57, Temperature = 20 };
            Planets planet6 = new Planets { Name = "Сатурн", Diametr = 120860, Age = 4.6, Livable = false, Distance = 1400, Temperature = -130 };
            Planets planet7 = new Planets { Name = "Уран", Diametr = 50720, Age = 4.5, Livable = false, Distance = 2871, Temperature = -220 };
            Planets planet8 = new Planets { Name = "Нептун", Diametr = 49500, Age = 4.6, Livable = false, Distance = 4500, Temperature = -201 };
            MongoInsert(planet1).GetAwaiter().GetResult();
            MongoInsert(planet2).GetAwaiter().GetResult();
            MongoInsert(planet3).GetAwaiter().GetResult();
            MongoInsert(planet4).GetAwaiter().GetResult();
            MongoInsert(planet5).GetAwaiter().GetResult();
            MongoInsert(planet6).GetAwaiter().GetResult();
            MongoInsert(planet7).GetAwaiter().GetResult();
            MongoInsert(planet8).GetAwaiter().GetResult();
        }

    }

}
