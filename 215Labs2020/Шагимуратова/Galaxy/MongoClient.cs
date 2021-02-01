using System;

namespace _215Labs2020.Шагимуратова.Galaxy
{
    internal class MongoClient
    {
        private string connectionString;

        public MongoClient(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal object GetDatabase(string v)
        {
            throw new NotImplementedException();
        }
    }
}