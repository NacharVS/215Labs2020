using System;

namespace _215Labs2020.Galyautdinov
{
    class StringOperations
    {
        public static void TheTask1()
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            Console.WriteLine($"Количество букв: {str}");
        }
        public static void TheTask2()
        {
            string s = Console.ReadLine();
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string det = string.Join(' ', words);
            Console.WriteLine(det);
        }
        public static void TheTask3()
        {
            string Even = "";
            string Odd = "";
            Console.WriteLine("Введиет слово");
            string s = Console.ReadLine();
            string set = s.Replace(" ", "");

            for (int i = 0; i < set.Length; i++)
            {
                if (i == 0)
                {
                    Odd += set[i] + "; ";
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Odd += set[i] + "; ";
                    }
                    else
                    {
                        Even += set[i] + "; ";
                    }
                }
            }
            Console.WriteLine($"Нечетный: {Odd}");
            Console.WriteLine($"Четный: {Even}");
        }
    }
}