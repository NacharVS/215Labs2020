using System;
using String_operation;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            StringOperation.col_bukv(Console.ReadLine());
            Console.Write("Введите текст: ");
            StringOperation.delete_probel(Console.ReadLine());
            Console.Write("Введите текст: ");
            StringOperation.chet_nechet_bukv(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
