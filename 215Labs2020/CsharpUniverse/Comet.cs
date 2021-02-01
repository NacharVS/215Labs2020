using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace _215Labs2020.CsharpUniverse
{
    class Comet : Planet
    {
        [BsonElement("Tale lenght")]
        public double lenght;
    }
}
