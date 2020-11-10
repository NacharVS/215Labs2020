using System;

namespace _215Labs2020.Galyautdinov.Delegates
{
    class GeneralOffice
    {
        public static void Max_el_array(int message)
        {
            Console.WriteLine($"Максимальный элемент массива {message}");
        }
        public static void Sum_el_array(int message)
        {
            Console.WriteLine($"Сумма элементов массива {message}");
        }
        public static void Sort_el_array(string message)
        {
            Console.WriteLine($"Сортировка массива {message}");
        }
        public static void SumArray(string message)
        {
            Console.WriteLine($"Сумма двух массива {message}");
        }
        public static void Sub_el_array(string message)
        {
            Console.WriteLine($"Разность двух массива {message}");
        }
        public static void Com_el_array(string message)
        {
            Console.WriteLine($"Произведение двух массива {message}");
        }
    }
}
