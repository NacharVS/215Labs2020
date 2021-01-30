using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace _215Labs2020.Sadukov
{
    class Bank
    {
        [BsonId]
        public Object id;
        [BsonElement("Name")]
        public string name;
        [BsonElement("Surname")]
        public string surname;
        [BsonIgnoreIfDefault]
        public int age;
        [BsonIgnoreIfDefault]
        public string Email;
        [BsonIgnoreIfDefault]
        public double money;



        static async Task SearchByName(string sname, string ssurname)
        { 
         


        
        }
    }
    
     
    
    
    
    
}

        
    

