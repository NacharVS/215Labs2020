using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using MongoDB.Bson.Serialization.Attributes;

namespace _215Labs2020.Faizullin.Bankssssa
{
    class MongoDBBank
    {
        [BsonId]
        public ObjectId _id;
        [BsonElement("Imya")]
        public string name;
        [BsonElement("Familiya")]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public int Email;
    }
    
    static async Task MongoInsert(Person person)
    {
        string connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var datebase = client.GetDatabase("215TeamDB");
        var collection = datebase.GetCollection<Person>("Person");
        //var clientt = new BsonDocument();
        await collection.InsertManyAsync(person);


    }
}
