using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace _215Labs2020.Garaev
{
    class Planets
    {
        [BsonElement("Name")]
        public string name;
        [BsonElement("Diametr")]
        public double diametr;
        [BsonElement("Age")]
        public long age;
        [BsonElement("Livable")]
        public bool Livable;
        [BsonElement("distance")]
        public double distance;
        [BsonElement("temperature")]
        public double temperature;
    }
    class Satellites
    {

    }
    class Comets
    {

    }
}
