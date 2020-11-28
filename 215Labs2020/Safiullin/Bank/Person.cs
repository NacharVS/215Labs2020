using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Bank
{
    abstract class Person
    {
        private static string _name;
        private static string _name1;
        public static string Forename
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public static string Forename1
        {
            get
            {
                return _name1;
            }
            set
            {
                _name1 = value;
            }
        }
    }
}
