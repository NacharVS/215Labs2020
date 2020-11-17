using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Galyautdinov;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    abstract class Person
    {
        private static string _name;
        private static string _name1;
        public static string Name
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
        public static string Name1
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
