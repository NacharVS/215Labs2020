using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Galyautdinov;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    class Person
    {

        private static string _surname;
        private string _name;
        private static int _id;
        public string SurName
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
        public string Name
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
    }
}
