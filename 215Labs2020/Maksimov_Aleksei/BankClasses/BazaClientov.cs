using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace _215Labs2020.Maksimov_Aleksei.BankClasses
{
    class BazaClientov
    {
        [BsonId]
        public object id;
        [BsonElement("Name")]
        public string name;
        [BsonElement("SurName")]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public int money;

        static async Task SearchByName()
        {

        }
    }
}

