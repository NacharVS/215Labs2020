using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace _215Labs2020.Imamov
{
    abstract class Employee
    {
        public static string name = "Oleg";
        public static string surname = "Maksimov";
        public static int payment = 8000;
    }
    abstract class User
    {
        public static string name;
        public static string surname;
        public static int date;
        public static int month;
        public static int year;
        public static int age;


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
        public static int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public static int Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public static int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

    }
}
