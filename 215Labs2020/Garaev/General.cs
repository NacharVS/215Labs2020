using _215Labs2020.Garaev.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev
{
    class General
    {
        public static int[] mass1 = new int[10];
        public static int[] mass2 = new int[10];
        public static void vibor()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(10, 99);
            }
            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = rnd.Next(10, 99);
            }
            Console.Write("Ваш первый массив: ");
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write($"{mass1[i]} ");
            }
            Console.WriteLine();
            Console.Write("Ваш второй массив: ");
            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write($"{mass2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1) Найти максимальный элемент первого массива");
            Console.WriteLine("2) Сумма элементов первого массива");
            Console.WriteLine("3) Сортировка первого массива");
            Console.WriteLine("4) Сумма двух массивов");
            Console.WriteLine("5) Разность элементов двух массивов");
            Console.WriteLine("6) Умножение двух массивов");
            Console.WriteLine("7) Выйти");
            int vibor = 0;
            try
            {
                vibor = int.Parse(Console.ReadLine());
            }
            catch
            {
                vibor = 7;
            }
            while(vibor < 7)
            {
                switch (vibor)
                {
                    case 1:
                        BranchOffice.max();
                        break;
                    case 2:
                        BranchOffice.Summ_el();
                        break;
                    case 3:
                        BranchOffice.Sortirovka();
                        break;
                    case 4:
                        BranchOffice.Summ_mass();
                        break;
                    case 5:
                        BranchOffice.raznost();
                        break;
                    case 6:
                        BranchOffice.MU();
                        break;
                }
                Console.Write("Нажмите ENTER: ");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Ваш первый массив: ");
                for (int i = 0; i < mass1.Length; i++)
                {
                    Console.Write($"{mass1[i]} ");
                }
                Console.WriteLine();
                Console.Write("Ваш второй массив: ");
                for (int i = 0; i < mass2.Length; i++)
                {
                    Console.Write($"{mass2[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Найти максимальный элемент первого массива");
                Console.WriteLine("2) Сумма элементов первого массива");
                Console.WriteLine("3) Сортировка первого массива");
                Console.WriteLine("4) Сумма двух массивов");
                Console.WriteLine("5) Разность элементов двух массивов");
                Console.WriteLine("6) Умножение двух массивов");
                Console.WriteLine("7) Выйти");
                try
                {
                    vibor = int.Parse(Console.ReadLine());
                }
                catch
                {
                    vibor = 7;
                }
                
            }
        }
    }
}
