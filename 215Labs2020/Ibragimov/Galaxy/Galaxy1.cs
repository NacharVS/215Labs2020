using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _215Labs2020.Ibragimov
{
    class Planet
    {

        [BsonElement("имя")]
        public string name;
        [BsonElement("диаметр")]
        [BsonIgnoreIfDefault]
        public double diameter;
        [BsonElement("температура")]
        [BsonIgnoreIfDefault]
        public int temperature;
        [BsonElement("Дистанция от солнца ")]
        [BsonIgnoreIfDefault]
        public double toSun;
        [BsonElement("Возвраст")]
        public double age;
        [BsonElement("Годность для жизни ")]
        [BsonIgnoreIfDefault]
        public bool fitLife;
        [BsonElement("С")]
        [BsonIgnoreIfDefault]
        public double speed;

        


        static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215");
            var collection = database.GetCollection<BsonDocument>("название");
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
            var database = client.GetDatabase("215");
            var collection = database.GetCollection<Planet>("название");
            await collection.InsertOneAsync(planet);


        }
        static async Task MongoInsert(Sattelite sat)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215");
            var collection = database.GetCollection<Sattelite>("название");
            await collection.InsertOneAsync(sat);


        }

        public static void start()
        {
            MongoConnect().GetAwaiter().GetResult();
            Planet mercury = new Planet { name = "Меркурий", age = 4.503, diameter = 4.87, fitLife = false, temperature = 480, speed = 0.24, toSun = 0.387 };
            Planet venus = new Planet { name = "    Венера", age = 4.503, diameter = 12.1, fitLife = false, temperature = 480, speed = 0.62, toSun = 0.723 };
            Planet earth = new Planet { name = "Земля", age = 4.503, diameter = 12.756, fitLife = true, temperature = 58, speed = 1, toSun = 1 };
            Planet mars = new Planet { name = "Марс", age = 4.603, diameter = 6.67, fitLife = false, temperature = -70, speed = 1.88, toSun = 1.52 };
            Sattelite moon = new Sattelite { name = "Луна", age = 4.53, art = false, diameter = 3.47, temperature = 127, owner = "Земля" };
            Sattelite phobos = new Sattelite { name = "Луна", age = 4.53, art = false, diameter = 3.47, temperature = 127, owner = "Земля" };
            MongoInsert(mercury).GetAwaiter().GetResult();
            MongoInsert(venus).GetAwaiter().GetResult();
            MongoInsert(earth).GetAwaiter().GetResult();
            MongoInsert(moon).GetAwaiter().GetResult();


        }
    }


}


