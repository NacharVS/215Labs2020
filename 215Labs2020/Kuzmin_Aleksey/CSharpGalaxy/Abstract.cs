using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;

namespace _215Labs2020.Kuzmin_Aleksey.CSharpGalaxy
{
    abstract class Abstract
    {
        [BsonId]
        public ObjectId _id;
        [BsonElement("_name")]
        public string _name;
        [BsonIgnoreIfDefault] //Диаметр планеты
        public double _diameter;
        [BsonIgnoreIfDefault] //Возраст планеты
        public double _age;
        [BsonIgnoreIfDefault] //Жизнь на планете
        public bool _life;
        [BsonIgnoreIfDefault] //Дистанция от солнца
        public double _distance;
        [BsonIgnoreIfDefault] //Является спутниеом планеты
        public string _belong;
        [BsonIgnoreIfDefault] //Искусственный или Естественный спутник
        public bool _artificial;
        [BsonIgnoreIfDefault] //Скорость кометы
        public double _speed; 
        [BsonIgnoreIfDefault] //Длина хвоста кометы
        public double _length;
        public static async Task MongoConnect(string _collection)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CSharpGalaxy");
            var collection = database.GetCollection<BsonDocument>(_collection);
            var _SpaceObject = new BsonDocument();
            var SpaceObject = await collection.Find(_SpaceObject).ToListAsync();
        }
        public static async Task MongoInsert(Abstract asbr)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("215TeamDB");
            var collection = database.GetCollection<Abstract>("CSharpGalaxy");
            await collection.InsertOneAsync(asbr);
        }
    }
}
