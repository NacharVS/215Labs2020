using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.Delegates
{
    class GeneralOffice
    { 
        public static void max() 
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            int max = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max) max = array1[i];
            }
            Console.WriteLine($"max {max}");
        
        }
        public static void sum()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine($"sum {sum}");
        }
        public static void sorting()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
            }
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


        }
        public static void summas()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd1.Next(1, 99);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
        public static void diffmas()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd1.Next(1, 99);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] - array2[i];
            }
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
        public static void mulmas()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd1.Next(1, 99);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
    }
}
