using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.BankKlas
{

    class Employee : yser
    {
        private static string rabname = "Олег";
        private static string rabsurname = "Иванов";
        private static int zarplata;
        private static int _id;
        public static string Rabname
        {
            get
            {
                return rabname;
            }
            set
            {
                rabname = value;
            }
        }

        public static string Rabsurname
        {
            get
            {
                return rabsurname;
            }
            set
            {
                rabsurname = value;
            }


        }
        public static int Zarplata
        {
            get
            {
                return zarplata;
            }
            set
            {
                zarplata = 45000;
            }
        }
        public static int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = 1;
            }
        }
    }

}
