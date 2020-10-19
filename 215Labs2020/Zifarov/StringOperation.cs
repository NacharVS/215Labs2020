using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov
{
    class StringOperation
    {
        public static void StringLength()
        {
            Console.WriteLine("Введите строку");
            string StringName = Console.ReadLine();
            StringName = StringName.Replace(" ","");

            Console.WriteLine($"Количество символов без пробелов: {StringName.Length}");
        }
        public static void DeleteSpace()
        {
            Console.WriteLine("Введите строку");
            string StringName = Console.ReadLine();
            string[] array = StringName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ' ');
            }
        }
        public static void EvenOddLatter()
        {
            Console.WriteLine("Введите строку");
            string StringName = Console.ReadLine();
            string one = "";
            string two = "";
            StringName = StringName.Replace(" ", "");
            for (int i = 0; i < StringName.Length; i++)
            {
                if (i % 2 == 0) one=one + StringName[i].ToString();
                else two = two + StringName[i].ToString();
            }
            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
