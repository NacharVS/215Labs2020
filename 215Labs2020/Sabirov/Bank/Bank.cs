using System;
using System.Xml.Serialization;

namespace _215Labs2020.Sabirov
{
     abstract class Bank
    {

       
       
        public static string name;
        private static int day;
        private static int month;
        private static int age;
        private static string email;
        private static int id;
        private static string surname;


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

        public static int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public static string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
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
                if (DateTime.Now.Year - value < 14)
                {
                    Console.WriteLine("You are underage");
                }
                else age = value;
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
        public static int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public static string Surname { get => surname; set => surname = value; }
    }
}
