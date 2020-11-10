using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Delegates
{
    class GeneralOffice
    {
        public static void max()
        {
            Random rnd = new Random();
            int[] array1 = new int[4] ;
            for (int i = 0; i <4; i++)
            {
                array1[i] = rnd.Next(10,111);
                Console.WriteLine(array1[i]);
            }
            
            int max = 0;
            
            for (int i = 0; i < array1.Length; i++)
            {
                
                if (max < array1[i])
                    max = array1[i];

                

            }
            
            Console.WriteLine($"max {max}");
        }
        public static void sum()
        {
            Random rnd = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array2[i] = rnd.Next(10, 111);
                Console.WriteLine(array2[i]);

            }
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum = sum + array2[i];
            }
            Console.WriteLine(sum);
        }
        public

    }
}
