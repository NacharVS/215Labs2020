using _215Labs2020.Galyautdinov.Delegates;
using System;

namespace _215Labs2020.Galyautdinov
{
    class General
    {
        public static int[] array1 = new int[5];
        public static int[] array2 = new int[5];
        public static void operation()
        {
            Random rnd = new Random();

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
            Console.WriteLine("Введите любое число для выхода");
            Console.Write("Выберите действие: ");
            int prov = Convert.ToInt32(Console.ReadLine());
            while (prov<7 && prov >0)
            {
                switch (prov)
                {
                    case 1:
                        BranchOffice.max(); 
                        break;
                    case 2:
                        BranchOffice.sum();
                        break;
                    case 3:
                        BranchOffice.sort();
                        break;
                    case 4:
                        BranchOffice.sumArray();
                        break;
                    case 5:
                        BranchOffice.sub_el_array();
                        break;
                    case 6:
                        BranchOffice.com_el_array();
                        break;
                }
                Console.WriteLine();
                try
                {
                    Console.Write("Выберите дальнейшие действие: ");
                    prov = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Выберите дальнейшие действие: ");
                    prov = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
