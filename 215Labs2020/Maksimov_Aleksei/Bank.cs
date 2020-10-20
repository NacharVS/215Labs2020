using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static int vklad = 0;
        public static void Name()
        {
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
        public static void Surname()
        {
            surname = Console.ReadLine();
        }
    }

}