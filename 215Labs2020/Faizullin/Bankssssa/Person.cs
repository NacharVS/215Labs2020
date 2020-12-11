using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin.Bankssssa
{
    abstract class Person
    {
        private static string _snf;
        private int _id;
        private int _age;

        public static string SNF
        {
            get
            {
                return _snf;
            }
            set
            {
                _snf = value;
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}

