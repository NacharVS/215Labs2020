using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;
using _215Labs2020.Kuzmin_Aleksey.CSharpGalaxy;

namespace _215Labs2020.Kuzmin_Aleksey.Galaxy
{
    class Planet : Abstract
    {       
        public static void Program()
        {
            MongoConnect("Planet").GetAwaiter().GetResult();
            Planet Mercury = new Planet { _name = "Mercury", _age = 4.503, _life = false, _diameter = 4.87, _distance = 0.387 };
            Planet Venus = new Planet { _name = "Venus", _age = 4.503, _life = false, _diameter = 12.1, _distance = 0.723 };
            Planet Earth = new Planet { _name = "Earth", _age = 4.503, _life = true, _diameter = 12.756};
            Planet Mars = new Planet { _name = "Mars", _age = 4.603, _life = false, _diameter = 6.67, _distance = 1.52 };
            MongoInsert(Mercury).GetAwaiter().GetResult();
            MongoInsert(Venus).GetAwaiter().GetResult();
            MongoInsert(Earth).GetAwaiter().GetResult();
        }
    }
}