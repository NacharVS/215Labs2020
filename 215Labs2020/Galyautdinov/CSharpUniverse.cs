using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _215Labs2020.Galyautdinov
{
    class Planets
    {
        [BsonElement("Название")]
        public string Name;
        [BsonElement("Диаметр")]
        public double Diametr;
        [BsonElement("Возраст")]
        public long Age;
        [BsonElement("Пригодное для жизни")]
        public bool Livable;
        [BsonElement("Растояние")]
        public double Distance;
        [BsonElement("Температура")]
        public double Temperature;
    }
    class Satellites
    {

    }
    class Comets
    {

    }
}
