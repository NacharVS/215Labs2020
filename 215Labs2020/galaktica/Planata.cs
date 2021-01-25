using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.galaktica
{
    class Planata
    {
        [BsonElement("Imya")]
        public string name;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public int diameter;
        [BsonIgnoreIfDefault]
        public int distance;
        [BsonIgnoreIfDefault]
        public int fit;
    }
}
