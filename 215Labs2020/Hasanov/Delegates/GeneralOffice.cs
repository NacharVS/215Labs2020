using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Delegates
{
    class GeneralOffice
    {
        
        
        
        public static void max(int[]array1)
        {
            
           
            int max = 0;
            
            for (int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i])
                    max = array1[i];
            }
            
            Console.WriteLine($"Максимальное значение {max}");
        }
        public static void sum(int [] array1)
        {
           
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine($"Сумма {sum}");

        }
        
        public static void sortirovka()
        {
            Console.WriteLine();
            Random rnd = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array2[i] = rnd.Next(10, 111);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            int buff;
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2.Length-1; j++)
                {
                    if (array2[j] >  array2[j+1] )
                    {
                        buff = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = buff;
                    }

                }

            }
            Console.WriteLine("Сортировка");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }

        public static void summmass()
        {
            Console.WriteLine();
            Random rnd = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array2[i] = rnd.Next(10, 111);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array3[i] = rnd.Next(10, 111);
                Console.WriteLine(array3[i]);
            }
            Console.WriteLine();
            int[] array4 = new int[4];
            Console.WriteLine("Сумма массивов");
            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = array3[i] + array2[i];
                Console.WriteLine(array4[i]);
            }
            
        }
        public static void razmass()
        {
            Console.WriteLine();
            Random rnd = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array2[i] = rnd.Next(10, 111);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array3[i] = rnd.Next(10, 111);
                Console.WriteLine(array3[i]);
            }
            Console.WriteLine();
            int[] array4 = new int[4];
            Console.WriteLine("Разность массивов");
            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = array3[i] - array2[i];
                Console.WriteLine(array4[i]);
            }
        }
        
        public static void umnmass()
        {
            Console.WriteLine();
            Random rnd = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array2[i] = rnd.Next(10, 111);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array3[i] = rnd.Next(10, 111);
                Console.WriteLine(array3[i]);
            }
            Console.WriteLine();
            int[] array4 = new int[4];
            Console.WriteLine("Умножение массивов");
            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = array3[i] * array2[i];
                Console.WriteLine(array4[i]);
            }
        }

    }
}
