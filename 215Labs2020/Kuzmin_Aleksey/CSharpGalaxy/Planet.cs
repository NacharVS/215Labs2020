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
            Planet Mercury = new Planet { _name = "Меркурий", _age = 4.503, _life = false, _diameter = 4.87, _distance = 58.6 };
            Planet Venus = new Planet { _name = "Венера", _age = 4.503, _life = false, _diameter = 12.1, _distance = 108.01 };
            Planet Earth = new Planet { _name = "Земля", _age = 4.503, _life = true, _diameter = 12.756, _distance = 149.6 };
            Planet Mars = new Planet { _name = "Марс", _age = 4.603, _life = false, _diameter = 6.67, _distance = 228 };
            Planet Jupiter = new Planet { _name = "Юпитер", _age = 4.6, _life = false, _diameter = 139.822, _distance = 740.57 };
            Planet Saturn = new Planet { _name = "Сатурн", _age = 4.6, _life = false, _diameter = 116.46, _distance = 1433.4 };
            Planet Uranus = new Planet { _name = "Уран", _age = 4.6, _life = false, _diameter = 51.024, _distance = 3004.65 };
            Planet Neptune = new Planet { _name = "Нептун", _age = 4.6, _life = false, _diameter = 49.5, _distance = 4500.83 };
            MongoInsert(Mercury).GetAwaiter().GetResult();
            MongoInsert(Venus).GetAwaiter().GetResult();
            MongoInsert(Earth).GetAwaiter().GetResult();
            MongoInsert(Mars).GetAwaiter().GetResult();
            MongoInsert(Jupiter).GetAwaiter().GetResult();
            MongoInsert(Saturn).GetAwaiter().GetResult();
            MongoInsert(Uranus).GetAwaiter().GetResult();
            MongoInsert(Neptune).GetAwaiter().GetResult();
        }
    }
}