using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov.Delegates
{
    class GeneralOffice
    {
        public static int[] array = { };
        public static void arr()
        {
            Random rnd = new Random();
            array = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 9);
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        public static void Max()
        {
            
            int c = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    c = array[i];   

                }
            }
            Console.WriteLine(c);
        }
        public static void sort() 
        {
            Array.Sort(array);
            foreach (int a in array)
                Console.Write(a);
        
        
        
        }
    }
}
