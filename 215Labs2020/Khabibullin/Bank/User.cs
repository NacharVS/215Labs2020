using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin
{
     abstract class User
    {
        public static string name;
        public static string surname;
        public static int date;
        public static int month;
        public static int year;
        public static int age;
        public static string EmployeeName = "Insaf";
        public static string EmployeeSurname = "Khabibullin";
        public static int payment;

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
                return Surname;
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
        public static string EmployeeN
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }
        public static string EmployeeS
        {
            get
            {
                return EmployeeSurname;
            }
            set
            {
                EmployeeSurname = value;
            }
        }
        public static int Pay
        {
            get
            {
                return payment;
            }
            set
            {
                payment = 6250;
            }
        }
    }
}
