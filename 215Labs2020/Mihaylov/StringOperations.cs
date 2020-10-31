using System;
namespace _215Labs2020.Mihaylov
{
    class StringOperations
    {
        private static void Length()
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            Console.WriteLine($"Количество символов в слове: {str.Length}");
        }

        private static void Entriesn()
    {
        Console.WriteLine("Введите слово");
        string str = Console.ReadLine();
        str = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine(str);
    }
        private static void OneTwo()
    {
        string two = "";
        string one = "";
        Console.WriteLine("Введите слово");
        string a = Console.ReadLine();
        string str = a.Replace(" ", "");

        for (int i = 0; i < str.Length; i++)
            if (i % 2 == 0)
            {
                one += str[i] + "; ";
            }
            else
            {
                two += str[i] + "; ";
            }
        Console.WriteLine($"Нечетный: {one}");
        Console.WriteLine($"Четный: {two}");
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Количество символов: ( 1 )");
                Console.WriteLine("Удаление лишних пробелов: ( 2 )");
                Console.WriteLine("Разделение на 1 и 2 строки: ( 3 )");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: Length(); break;
                    case 2: Entriesn(); break;
                    case 3: OneTwo(); break;
                }
            }
        }
    }
}