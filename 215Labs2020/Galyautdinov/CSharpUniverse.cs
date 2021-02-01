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
        public Planets(string name, double diam, double age, bool live, double dis, double temp)
        {
            Name = name;
            Diametr = diam;
            Age = age;
            Livable = live;
            Distance = dis;
            Temperature = temp;
        }
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
            var mercury = new Planets ("Меркурий", 4879.4, 4.6, false, 58, 427);
            var venus = new Planets ("Венера", 12103.6, 4.6, false, 108, 470 );
            var earth = new Planets ("Земля", 12742, 4.54, true, 149.6, 56.7 );
            var mars = new Planets ("Марс", 6739.8, 4.65, true, 228, 20);
            var jupiter = new Planets ("Юпитер", 143884, 5, false, 778.57, 20);
            var saturn = new Planets ("Сатурн", 120860, 4.6, false, 1400,-130);
            var uranus = new Planets ("Уран", 50720, 4.5, false, 2871,-220);
            var neptune = new Planets ("Нептун", 49500,  4.6, false, 4500,-201 );

            //MongoReplaceByName("Нептун", new Planets() { Name = "Хребтун" }).GetAwaiter().GetResult();
            MongoInsert(mercury).GetAwaiter().GetResult();
            MongoInsert(venus).GetAwaiter().GetResult();
            MongoInsert(earth).GetAwaiter().GetResult();
            MongoInsert(mars).GetAwaiter().GetResult();
            MongoInsert(jupiter).GetAwaiter().GetResult();
            MongoInsert(saturn).GetAwaiter().GetResult();
            MongoInsert(uranus).GetAwaiter().GetResult();
            MongoInsert(neptune).GetAwaiter().GetResult();
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

        public Satellites(string name, bool art, double age)
        {
            Name = name;
            Artificial = art;
            Age = age;
        }
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
            var moon = new Satellites("Луна", false, 4.51 );
            var io = new Satellites("Ио", false, 0.001 );
            var starlink = new Satellites("Starlink", false,0.000000003);

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

        public Comets(string name, double size, double speed, double t_length, double temp)
        {
            Name = name;
            Size = size;
            Speed = speed;
            Tail_length = t_length;
            Temperature = temp;
        }
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
            var ISON = new Comets("ISON",100,380,16, 3000);
            var galea = new Comets("Galea",15, 45, 100, 130 );

            MongoInsert(ISON).GetAwaiter().GetResult();
            MongoInsert(galea).GetAwaiter().GetResult();
        }
    }
}
