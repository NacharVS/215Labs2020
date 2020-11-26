using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    abstract class Person
    {
        private static string name;
        private static string surname;
        private static int age;
        private static int dt;
        private static int mm;
        private static int yy;

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public static int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
