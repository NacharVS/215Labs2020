using _215Labs2020.Galyautdinov.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class General
    {
        public static void vibor()
        {
            Random rnd = new Random();

            int[] array1 = new int[5];
            int[] array2 = new int[5];
            Console.Write("1-array:  ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 9);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.Write("2-array:  ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 9);
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.Максимальный элемент массива");
            Console.WriteLine("2.Сумма всех элементов массива");
            Console.WriteLine("3.Сортировка массива ");
            Console.WriteLine("4.Сумма двух массивов(поэлементно)");
            Console.WriteLine("5.Разность элементов 2 массива");
            Console.WriteLine("6.Умножение элементов 2 массива");
            Console.Write("Выберите действие: ");
            int prov = Convert.ToInt32(Console.ReadLine());
            while (prov<7 && prov >0)
            {
                switch (prov)
                {
                    case 1: BranchOffice.max(); break;
                }
                Console.Write("Выберите дальнейшие действие: ");
                prov = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
