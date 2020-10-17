using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.StringOperation
{
    public static class Characters
    {
        public static string _stringName;
        public static void Readstring()
        {
            Console.WriteLine("Введите строку");
            Characters._stringName = Console.ReadLine();
            Characters.Chr(Characters._stringName);
        }
            
        public static void Chr (string stringname)
        {

            Console.WriteLine(stringname.Length - 1);
            
            
        }
    }
}
