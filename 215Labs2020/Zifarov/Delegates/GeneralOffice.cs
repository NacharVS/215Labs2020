using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.Delegates
{
    class GeneralOffice
    { 
        public static void max(int[]array1) 
        {
            
            int max = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max) max = array1[i];
            }
            Console.WriteLine($"max {max}");
        
        }
        public static void sum(int[] array1)
        {
            
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine($"sum {sum}");
        }
        public static void sorting(int[] array1)
        {
            Console.WriteLine("Сортировка");
            int buffer;
            for (int i = 0; i < array1.Length; i++)
            {


                for (int j = 0; j < array1.Length - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        buffer = array1[j];
                        array1[j] = array1[j+1];
                        array1[j+1] = buffer;
                        
                    }
                    
                }
                
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();

        }
        public static void summas(int[] array1, int[] array2)
        {
            Console.WriteLine("Сумма массивов");
            int sum;
            for (int i = 0; i < array1.Length; i++)
            {
               sum = array1[i] + array2[i];
                Console.WriteLine(sum);
            }
            Console.WriteLine();
        }
        public static void diffmas(int[] array1, int[] array2)
        {
            Console.WriteLine("Разность массивов");
            int dif;
           
            for (int i = 0; i < array1.Length; i++)
            {
                dif = array1[i] - array2[i];
                Console.WriteLine(dif);
            }
            Console.WriteLine();
        }
        public static void mulmas(int[] array1, int[] array2)
        {
            
            Console.WriteLine("Умножение массивов");
            int mul;
            for (int i = 0; i < array1.Length; i++)
            {
                mul = array1[i] * array2[i];
                Console.WriteLine(mul);
            }
           
        }
    }
}
