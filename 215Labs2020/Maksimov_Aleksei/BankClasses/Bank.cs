using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
{
    abstract class Bank
    {
        
        private static int age;
        private static int dt;
        private static int mm;
        private static int yy;
        private static string name;
        public static string surname;

        




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
        public static int Dt
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }
        public static int Mm
        {
            get
            {
                return mm;
            }
            set
            {
                mm = value;
            }
        }
        public static int Yy
        {
            get
            {
                return yy;
            }
            set
            {
                yy = value;
            }
        }

    }
}
