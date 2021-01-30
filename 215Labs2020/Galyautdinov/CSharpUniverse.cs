using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace _215Labs2020.Galyautdinov
{
    class Planets
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string Name;
        [BsonElement("Диаметр [км]")]
        public double Diametr;
        [BsonElement("Возраст [млрд лет]")]
        public double Age;
        [BsonElement("Пригодное для жизни")]
        public bool Livable;
        [BsonElement("Растояние [мил км]")]
        public double Distance;
        [BsonElement("Температура [°C]")]
        public double Temperature;
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
            await collection.InsertOneAsync(pl);

        }
        public static async Task MongoReplaceByName(string SerachByName, Planets new_pl)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Planets>("Planets");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_pl);

        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Planets mercury = new Planets { Name = "Меркурий", Diametr =  4879.4, Age = 4.6, Livable = false,  Distance = 58, Temperature = 427 };
            Planets venus = new Planets { Name = "Венера", Diametr = 12103.6, Age = 4.6, Livable = false, Distance = 108, Temperature = 470 };
            Planets earth = new Planets { Name = "Земля", Diametr = 12742, Age = 4.54, Livable = true, Distance = 149.6, Temperature = 56.7 };
            Planets mars = new Planets { Name = "Марс", Diametr = 6739.8, Age = 4.65, Livable = true, Distance = 228, Temperature = 20 };
            Planets jupiter = new Planets { Name = "Юпитер", Diametr = 143884, Age = 5, Livable = false, Distance = 778.57, Temperature = 20 };
            Planets saturn = new Planets { Name = "Сатурн", Diametr = 120860, Age = 4.6, Livable = false, Distance = 1400, Temperature = -130 };
            Planets uranus = new Planets { Name = "Уран", Diametr = 50720, Age = 4.5, Livable = false, Distance = 2871, Temperature = -220 };
            Planets neptune = new Planets { Name = "Нептун", Diametr = 49500, Age = 4.6, Livable = false, Distance = 4500, Temperature = -201 };

            //MongoReplaceByName("Нептун", new Planets() { Name = "Хребтун" }).GetAwaiter().GetResult();
            //MongoInsert(mercury).GetAwaiter().GetResult();
            //MongoInsert(venus).GetAwaiter().GetResult();
            //MongoInsert(earth).GetAwaiter().GetResult();
            //MongoInsert(mars).GetAwaiter().GetResult();
            //MongoInsert(jupiter).GetAwaiter().GetResult();
            //MongoInsert(saturn).GetAwaiter().GetResult();
            //MongoInsert(uranus).GetAwaiter().GetResult();
            //MongoInsert(neptune).GetAwaiter().GetResult();
        }
    }
    class Satellites
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string Name;
        [BsonElement("Искуственный?")]
        public bool Artificial;
        [BsonElement("Возраст [млрд лет]")]
        public double Age;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<BsonDocument>("Satellites");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(Satellites st)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Satellites>("Satellites");
            await collection.InsertOneAsync(st);

        }
        public static async Task MongoReplaceByName(string SerachByName, Satellites new_st)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Satellites>("Satellites");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_st);

        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Satellites moon = new Satellites() { Name = "Луна", Age = 4.51, Artificial = false };
            Satellites io = new Satellites() { Name = "Ио", Age = 0.001, Artificial = false };
            Satellites starlink = new Satellites() { Name = "Starlink", Age = 0.000000003, Artificial = true };

            MongoInsert(moon).GetAwaiter().GetResult();
            MongoInsert(io).GetAwaiter().GetResult();
            MongoInsert(starlink).GetAwaiter().GetResult();
        }
    }
    class Comets
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string Name;
        [BsonElement("Скорость [км/с]")]
        public double Speed;
        [BsonElement("Размер")]
        public double Size;
        [BsonElement("Длина хвоста")]
        public double Tail_length;
        [BsonElement("Температура [°C]")]
        public double Temperature;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<BsonDocument>("Comets");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(Comets cm)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Comets>("Comets");
            await collection.InsertOneAsync(cm);

        }
        public static async Task MongoReplaceByName(string SerachByName, Comets new_cm)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Universe");
            var collection = database.GetCollection<Comets>("Comets");
            await collection.ReplaceOneAsync(std => std.Name == SerachByName, new_cm);

        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Comets ISON = new Comets() { Name = "ISON", Size =  100, Speed = 380, Tail_length = 16, Temperature = 3000};
            Comets galea = new Comets() { Name = "Galea", Size = 15, Speed = 45, Tail_length = 100, Temperature = 130 };

            MongoInsert(ISON).GetAwaiter().GetResult();
            MongoInsert(galea).GetAwaiter().GetResult();
        }
    }
}
