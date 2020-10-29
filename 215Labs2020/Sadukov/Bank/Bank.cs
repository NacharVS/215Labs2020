using System;

namespace _215Labs2020.Sadukov
{
    abstract class Bank
    {

        private static string name;
        private static int day;
        private static int month;
        private static int age;
        private static string email;
        

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
       
       
    }
}

        
    

