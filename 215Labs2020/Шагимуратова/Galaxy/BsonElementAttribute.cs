using System;

namespace _215Labs2020.Шагимуратова.Galaxy
{
    internal class BsonElementAttribute : Attribute
    {
        private string v;

        public BsonElementAttribute(string v)
        {
            this.v = v;
        }
    }
}