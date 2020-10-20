using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class StringOperations
    {
        public static void Ex1()
        {
            Console.Write("Введите строку: ");
            string Line = Console.ReadLine();
            Console.WriteLine($"Колличество символов в строке {Line.Length}");
        }
        public static void Ex2()
        {
            Console.Write("Введите строку: ");
            string Line = Console.ReadLine();
            string[] mass = Line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
        public static void Ex3()
        {
            Console.Write("Введите строку: ");
            string Line = Console.ReadLine();
            string even = "";
            string uneven = "";
            Line = Line.Replace(" ", " ");
            for (int i = 0; i < Line.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += Line[i] + " ";
                }
                else
                {
                    uneven += Line[i] + " ";
                }
            }
            Console.WriteLine(even);
            Console.WriteLine(uneven);
        }
    }
}
