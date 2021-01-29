using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.Galaxy
{
    class planets
    {
        
        [BsonElement("Name")]
        public string name;
        [BsonElement("Diametr")]
        public int diametr;
        [BsonIgnoreIfDefault("Age")]
        public int age;
        [BsonIgnoreIfDefault("Life")]
        public bool life;
        [BsonIgnoreIfDefault("Distance")]
        public int distance;
        [BsonIgnoreIfDefault("Temperature")]
        public int temp;

        static async Task 
    }
}
