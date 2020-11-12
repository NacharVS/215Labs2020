using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    abstract class Person
    {
        private static string _name;
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
    }
}
