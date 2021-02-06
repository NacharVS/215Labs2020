//using System;
//using System.Collections.Generic;
//using System.Text;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using MongoDB.Bson.Serialization.Attributes;
//using System.Threading.Tasks;


//namespace ConsoleApp31
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Planets.Main1();
//        }
//    }
//    class Planets
//    {
//        [BsonElement("Имя")]
//        public string Name;
//        [BsonElement("Диаметр (км)")]
//        public double Diametr;
//        [BsonElement("Возраст (млрд лет)")]
//        public double Age;
//        [BsonElement("Жизнепригодный?")]
//        public bool Livable;
//        [BsonElement("Расстояние до Солнца (млн км)")]
//        public double Distance;
//        [BsonElement("Температура (°С)")]
//        public double Temperature;
//        private static async Task MongoConnect()
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<BsonDocument>("Planets");
//            var user_client = new BsonDocument();
//            var user_clients = await collection.Find(user_client).ToListAsync();
//        }
//        private static async Task MongoInsert(Planets planet)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Planets>("Planets");
//            await collection.InsertOneAsync(planet);
//        }
//        public static void Main1()
//        {
//            MongoConnect().GetAwaiter().GetResult();
//            Planets planet1 = new Planets { Name = "Меркурий", Diametr = 4879.4, Age = 4.6, Livable = false, Distance = 58, Temperature = 427 };
//            Planets planet2 = new Planets { Name = "Венера", Diametr = 12103.6, Age = 4.6, Livable = false, Distance = 108, Temperature = 470 };
//            Planets planet3 = new Planets { Name = "Земля", Diametr = 12742, Age = 4.54, Livable = true, Distance = 149.6, Temperature = 56.7 };
//            Planets planet4 = new Planets { Name = "Марс", Diametr = 6739.8, Age = 4.65, Livable = true, Distance = 228, Temperature = 20 };
//            Planets planet5 = new Planets { Name = "Юпитер", Diametr = 143884, Age = 5, Livable = false, Distance = 778.57, Temperature = 20 };
//            Planets planet6 = new Planets { Name = "Сатурн", Diametr = 120860, Age = 4.6, Livable = false, Distance = 1400, Temperature = -130 };
//            Planets planet7 = new Planets { Name = "Уран", Diametr = 50720, Age = 4.5, Livable = false, Distance = 2871, Temperature = -220 };
//            Planets planet8 = new Planets { Name = "Нептун", Diametr = 49500, Age = 4.6, Livable = false, Distance = 4500, Temperature = -201 };
//            MongoInsert(planet1).GetAwaiter().GetResult();
//            MongoInsert(planet2).GetAwaiter().GetResult();
//            MongoInsert(planet3).GetAwaiter().GetResult();
//            MongoInsert(planet4).GetAwaiter().GetResult();
//            MongoInsert(planet5).GetAwaiter().GetResult();
//            MongoInsert(planet6).GetAwaiter().GetResult();
//            MongoInsert(planet7).GetAwaiter().GetResult();
//            MongoInsert(planet8).GetAwaiter().GetResult();
//        }
//        private static async Task MongoConnect()
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<BsonDocument>("Planets");
//            var user_client = new BsonDocument();
//            var user_clients = await collection.Find(user_client).ToListAsync();
//        }
//        private static async Task MongoInsert(Planets planet)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Planets>("Planets");
//            await collection.InsertOneAsync(planet);
//        }
//        public static async Task MongoReplacePlanets(string searchName, Planets newplanets)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Planets>("Planets");
//            await collection.ReplaceOneAsync(x => x.Name == searchName, newplanets);
//        }
//    }
//    class Satellites
//    {
//        [BsonElement("Имя")]
//        public string Name;
//        [BsonElement("Возраст (млрд лет)")]
//        public double Age;
//        [BsonElement("Искусственный?")]
//        public bool Artificiality;
//        private static async Task MongoConnect()
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<BsonDocument>("Satellites");
//            var user_client = new BsonDocument();
//            var user_clients = await collection.Find(user_client).ToListAsync();

//        }
//        private static async Task MongoInsert(Satellites satellit)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Satellites>("Satellites");
//            await collection.InsertOneAsync(satellit);
//        }
//        public static void Main2()
//        {
//            MongoConnect().GetAwaiter().GetResult();
//            Satellites satellites1 = new Satellites { Name = "Луна", Age = 4.51, Artificiality = false };
//            Satellites satellites2 = new Satellites { Name = "Ио", Age = 0.001, Artificiality = false };
//            Satellites satellites3 = new Satellites { Name = "Starlink", Age = 0.000000003, Artificiality = true };
//            MongoInsert(satellites1).GetAwaiter().GetResult();
//            MongoInsert(satellites2).GetAwaiter().GetResult();
//            MongoInsert(satellites3).GetAwaiter().GetResult();
//        }
//        public static async Task MongoReplaceSatellites(string searchName, Satellites newsatellites)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Satellites>("Satellites");
//            await collection.ReplaceOneAsync(x => x.Name == searchName, newsatellites);
//        }
//    }
//    class Comets
//    {
//        [BsonElement("Имя")]
//        public string Name;
//        [BsonElement("Скорость (км/с)")]
//        public double Speed;
//        [BsonElement("Размер (м)")]
//        public double Size;
//        [BsonElement("Длина хвоста")]
//        public double Length;
//        [BsonElement("Температура (°C)")]
//        public double Temperature;

//        private static async Task MongoConnect()
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<BsonDocument>("Comets");
//            var user_client = new BsonDocument();
//            var user_clients = await collection.Find(user_client).ToListAsync();

//        }
//        private static async Task MongoInsert(Comets comet)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Comets>("Comets");
//            await collection.InsertOneAsync(comet);
//        }
//        public static void Main3()
//        {
//            MongoConnect().GetAwaiter().GetResult();
//            Comets satellites1 = new Comets { Name = "Галлея", Speed = 4.51, Length = 100, Size = 11000, Temperature = 3000 };
//            Comets satellites2 = new Comets { Name = "Лавджоя", Speed = 0.001, Length = 30, Size = 500, Temperature = 500 };
//            MongoInsert(satellites1).GetAwaiter().GetResult();
//            MongoInsert(satellites2).GetAwaiter().GetResult();
//        }
//        public static async Task MongoReplaceKomets(string searchName, Comets newkomets)
//        {
//            string connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var database = client.GetDatabase("Gallactic");
//            var collection = database.GetCollection<Comets>("Planets");
//            await collection.ReplaceOneAsync(x => x.Name == searchName, newkomets);
//        }
//    }
//}

    


