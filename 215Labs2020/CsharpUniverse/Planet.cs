using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace _215Labs2020.CsharpUniverse
{
    class Planet
    {

        [BsonElement("Name")]
        public string name;
        [BsonElement("Diameter")]
        [BsonIgnoreIfDefault]
        public double diameter;
        [BsonElement("temperature")]
        [BsonIgnoreIfDefault]
        public int temperature;
        [BsonElement("Distance to the sun")]
        [BsonIgnoreIfDefault]
        public double toSun;
        [BsonElement("Age")]
        public double age;
        [BsonElement("Is it fit for life")]
        [BsonIgnoreIfDefault]
        public bool fitLife;
        [BsonElement("Speed")]
        [BsonIgnoreIfDefault]
        public double speed;

        
      

        static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<BsonDocument>("CSharpUniverse");
            var planet = new BsonDocument();
            var universal = await collection.Find(planet).ToListAsync();
            foreach (var item in universal)
            {
                Console.WriteLine(item);
            }
        }
         static async Task MongoInsert(Planet planet)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Planet>("CSharpUniverse");
            await collection.InsertOneAsync(planet);
            

        }
        static async Task MongoInsert(Comet comet)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Comet>("CSharpUniverse");
            await collection.InsertOneAsync(comet);


        }
        static async Task MongoInsert(Sattelite sat)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Sattelite>("CSharpUniverse");
            await collection.InsertOneAsync(sat);


        }
        public static async Task ReplaceByName(string SerachByName, Planet newpl)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Planet>("CSharpUniverse");
            await collection.ReplaceOneAsync(std => std.name == SerachByName, newpl);

        }
        public static async Task ReplaceByName(string SerachByName, Comet newco)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Comet>("CSharpUniverse");
            await collection.ReplaceOneAsync(std => std.name == SerachByName, newco);

        }
        public static async Task ReplaceByName(string SerachByName, Sattelite newsat)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Sattelite>("CSharpUniverse");
            await collection.ReplaceOneAsync(std => std.name == SerachByName, newsat);

        }
        static async Task MongoInsertByUser()
        {
            //string names, double diametr, int temp, double tosun, double ages, bool fit, double speeds
            string name = Console.ReadLine();
            double dia = double.Parse(Console.ReadLine());
            int temp = int.Parse(Console.ReadLine());
            double sun = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            bool fit = bool.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            Planet sat = new Planet { name = name, diameter=  dia,temperature = temp,toSun = sun,age = age,fitLife = fit,speed = speed };
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Planet>("CSharpUniverse");
            await collection.InsertOneAsync(sat);


        }
        public static void begin()
        {
            MongoConnect().GetAwaiter().GetResult();
            MongoInsertByUser().GetAwaiter().GetResult();
            Planet mercury = new Planet { name = "Mercury", age = 4.503, diameter = 4.87, fitLife = false, temperature = 480, speed = 0.24, toSun = 0.387 };
            Planet venus = new Planet { name = "Venus", age = 4.503, diameter = 12.1, fitLife = false, temperature = 480, speed = 0.62, toSun = 0.723};
            Planet earth = new Planet { name = "Earth", age = 4.503, diameter = 12.756, fitLife = true, temperature = 58, speed = 1, toSun = 1 };
            Planet mars = new Planet { name = "Mars", age = 4.603, diameter = 6.67, fitLife = false, temperature = -70, speed = 1.88, toSun = 1.52 };
            Sattelite moon = new Sattelite { name = "Moon", age = 4.53, art = false, diameter = 3.47, temperature =127, owner = "Earth"};
            Sattelite phobos = new Sattelite { name = "Moon", age = 4.53, art = false, diameter = 3.47, temperature = 127, owner = "Earth" };
            Comet ayaz = new Comet { age = 3.23, name = "ayaz", speed = 30, lenght = 30 };
            //MongoInsert(mercury).GetAwaiter().GetResult();
            //MongoInsert(venus).GetAwaiter().GetResult();
            //MongoInsert(earth).GetAwaiter().GetResult();
            //MongoInsert(moon).GetAwaiter().GetResult();
            //MongoInsert(ayaz).GetAwaiter().GetResult();
            //MongoInsert(mars).GetAwaiter().GetResult();
            ReplaceByName("Earth", new Planet { name = "Mercury", age = 100, diameter = 123, fitLife = false, speed = 10, temperature = 100, toSun = 3000 }).GetAwaiter().GetResult();
            ReplaceByName("Moon", new Sattelite { name = "Europe", age = 4.53, art = true, diameter = 3.47, temperature = 127, owner = "Mars" }).GetAwaiter().GetResult();
            ReplaceByName("ayaz", new Comet { age = 90, name = "MERC", speed = 23, lenght = 123 }).GetAwaiter().GetResult();


        }    
    }
    
}
