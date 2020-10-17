using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class StringOperations
    {
        public static void TheTask1()
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            Console.WriteLine($"Количество букв: {str.Length}");
        }
    }
}
