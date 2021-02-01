
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace _215Labs2020.Ibragimov
{
    class Sattelite : Planet
    {
        [BsonElement("Artificial")]
        public bool art;
        [BsonElement("Owned by")]
        [BsonIgnoreIfDefault]
        public string owner;


    }

}