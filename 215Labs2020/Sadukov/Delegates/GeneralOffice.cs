using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _215Labs2020.Sadukov.Delegates
{
    class GeneralOffice
    {
        public static int[] array = { };
        public static void arr1()
        {
            Console.WriteLine("Первый массив:");
            Random rnd = new Random();
            array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 9);
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        public static int[] array2 = { };
        public static void arr2()
        {
            Console.WriteLine("Второй массив:");
            Random rnd = new Random();
            array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 9);
                Console.Write(array2[i]);
            }
            Console.WriteLine();
        }
        public static void Summ()
        {
            Console.WriteLine("Сложение:");
            int [] sum = new int[5];
            for (int i = 0; i < sum.Length; i++)
            {  
                    sum[i] = array[i] + array2[i];
                    Console.Write($"{sum[i]} ");
                
            }
            Console.WriteLine();
        }
        public static void Sub()
        {
            Console.WriteLine("Вычитание:");
            int[] sub = new int[5];
            for (int i = 0; i < sub.Length; i++)
            {
                sub[i] = array[i] - array2[i];
                Console.Write($"{sub[i]} ");

            }
            Console.WriteLine();
        }
        public static void Mul()
        {
            Console.WriteLine("Умножение:");
            int[] mul = new int[5];
            for (int i = 0; i < mul.Length; i++)
            {
                mul[i] = array[i] * array2[i];
                Console.Write($"{mul[i]} ");

            }
            Console.WriteLine();
        }
        public static void Max()
        {
            
            int [] iop = array;
            int max = iop.Max();
            Console.WriteLine($"Максимальное число первого массива: {max} "); 
        }
        
        public static void sort() 
        {

            Array.Sort(array);
            Console.WriteLine("Сортированный первый массив:");
            foreach (int a in array)
                Console.Write($"{a} ");
            Console.WriteLine();
        }
        
       
    }
}
