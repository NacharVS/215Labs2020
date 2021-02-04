using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;

namespace _215Labs2020.Kuzmin_Aleksey.CSharpGalaxy
{
    class Satellite : Abstract
    {
        public static void Program()
        {
            MongoConnect("Satellite").GetAwaiter().GetResult();
            Satellite Mariner10 = new Satellite { _name = "Маринер-10", _belong = "Меркурий", _artificial = true };
            Satellite Moon = new Satellite { _name = "Луна", _belong = "Земля", _artificial = false };
            Satellite Phobos = new Satellite { _name = "Фобос", _belong = "Марс", _artificial = false };
            Satellite Io = new Satellite { _name = "Ио", _belong = "Юпитер", _artificial = false };
            Satellite Titanium = new Satellite { _name = "Титан", _belong = "Сатурн", _artificial = false };
            Satellite Pan = new Satellite { _name = "Пан", _belong = "Сатурн", _artificial = false };

            MongoInsert(Mariner10).GetAwaiter().GetResult();
            MongoInsert(Moon).GetAwaiter().GetResult();
            MongoInsert(Phobos).GetAwaiter().GetResult();
            MongoInsert(Io).GetAwaiter().GetResult();
            MongoInsert(Titanium).GetAwaiter().GetResult();
            MongoInsert(Pan).GetAwaiter().GetResult();

        }
    }
}
