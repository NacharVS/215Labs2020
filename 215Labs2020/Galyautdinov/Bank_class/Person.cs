using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Galyautdinov;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    abstract class Person
    {

        private static string _surname;
        private static string _name;
        private static int _id;
        public static string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
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
        public static int ID
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
    }
}
