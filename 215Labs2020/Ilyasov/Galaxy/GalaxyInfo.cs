using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading.Tasks;



namespace _215Labs2020.Ilyasov.Galaxy
{
    class GalaxyInfo
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public object _id;
        [BsonElement("Имя")]
        public string name;
        [BsonElement("Диаметр")]
        public double diametr;
        [BsonElement("Возраст [Млрд лет]")]
        public double age;
        [BsonElement("Есть ли жизнь?")]
        public bool life;
        [BsonElement("Расстояние от солнца [Млн км]")]
        public double sunkm;
        [BsonElement("Температура [По цельсию]")]
        public double temperature;
        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<BsonDocument>("Planet");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(GalaxyInfo p)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<GalaxyInfo>("Planet");
            await collection.InsertOneAsync(p);
        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            GalaxyInfo Mercury = new GalaxyInfo { name = "Меркурий", diametr = 4879.4, age = 4.6, life = false, sunkm = 58, temperature = 427 };
            GalaxyInfo Venera = new GalaxyInfo { name = "Венера", diametr = 12103.6, age = 4.6, life = false, sunkm = 108, temperature = 470 };
            GalaxyInfo Earth = new GalaxyInfo { name = "Земля", diametr = 12742, age = 4.54, life = true, sunkm = 149.6, temperature = 56.7 };
            GalaxyInfo Mars = new GalaxyInfo { name = "Марс", diametr = 6739.8, age = 4.65, life = true, sunkm = 228, temperature = 20 };
            GalaxyInfo Jupiter = new GalaxyInfo { name = "Юпитер", diametr = 143884, age = 5, life = false, sunkm = 778.57, temperature = 20 };
            GalaxyInfo Saturn = new GalaxyInfo { name = "Сатурн", diametr = 120860, age = 4.6, life = false, sunkm = 1400, temperature = -130 };
            GalaxyInfo Uran = new GalaxyInfo { name = "Уран", diametr = 50720, age = 4.5, life = false, sunkm = 2871, temperature = -220 };
            GalaxyInfo Neptune = new GalaxyInfo { name = "Нептун", diametr = 49500, age = 4.6, life = false, sunkm = 4500, temperature = -201 };

            MongoInsert(Mercury).GetAwaiter().GetResult();
            MongoInsert(Venera).GetAwaiter().GetResult();
            MongoInsert(Earth).GetAwaiter().GetResult();
            MongoInsert(Mars).GetAwaiter().GetResult();
            MongoInsert(Jupiter).GetAwaiter().GetResult();
            MongoInsert(Saturn).GetAwaiter().GetResult();
            MongoInsert(Uran).GetAwaiter().GetResult();
            MongoInsert(Neptune).GetAwaiter().GetResult();
        }
    }

    class Sputniki
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string name;
        [BsonElement("Искуственность")]
        public bool realy;
        [BsonElement("Возраст [Млрд лет]")]
        public double age;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<BsonDocument>("Sputniki");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(Sputniki st)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<Sputniki>("Sputniki");
            await collection.InsertOneAsync(st);

        }
        public static async Task MongoReplaceByName(string SerachByName, Sputniki new_st)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<Sputniki>("Sputniki");
            await collection.ReplaceOneAsync(std => std.name == SerachByName, new_st);
        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Sputniki moon = new Sputniki() { name = "Луна", age = 4.51, realy = true };
            Sputniki Mir = new Sputniki() { name = "Мир", age = 0.000001, realy = false };
            Sputniki Habbl = new Sputniki() { name = "Хаббл", age = 0.0000045, realy = true };

            MongoInsert(moon).GetAwaiter().GetResult();
            MongoInsert(Mir).GetAwaiter().GetResult();
            MongoInsert(Habbl).GetAwaiter().GetResult();
        }
    }
    class Comets
    {



        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("Имя")]
        public string name;
        [BsonElement("Скорость [км/с]")]
        public double Speed;
        [BsonElement("Размер")]
        public double size;
        [BsonElement("Длина хвоста")]
        public double taillength;
        [BsonElement("Температура по цельсию")]
        public double temperature;

        private static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<BsonDocument>("Comets");
            var bson = new BsonDocument();
            var bsons = await collection.Find(bson).ToListAsync();
        }
        private static async Task MongoInsert(Comets cm)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<Comets>("Comets");
            await collection.InsertOneAsync(cm);
        }
        public static async Task MongoReplaceByName(string Serachname, Comets new_cm)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Galaxy");
            var collection = database.GetCollection<Comets>("Comets");
            await collection.ReplaceOneAsync(std => std.name == Serachname, new_cm);
        }
        public static void Run()
        {
            MongoConnect().GetAwaiter().GetResult();
            Comets Bruksa = new Comets() { name = "Брукса", size = 120, Speed = 298, taillength = 12, temperature = 2600 };
            Comets Belyavskogo = new Comets() { name = "Белявского", size = 37, Speed = 67, taillength = 97, temperature = 9852 };

            MongoInsert(Bruksa).GetAwaiter().GetResult();
            MongoInsert(Belyavskogo).GetAwaiter().GetResult();
        }
    }
}
