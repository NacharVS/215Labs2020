using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Galyautdinov;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    abstract class Person
    {
        private static string _name;
        private static int _id;
        //private static double _bank_balans;
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
        /*public static double bank_balans
        {
            get
            {
                return _bank_balans;
            }
            set
            {
                _bank_balans = value;
            }
        }*/
    }
}
