using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    class potoki
    {

        static void Main(string[] args)
        {
            int[] mus1 = new int[10];
            int[] mus2 = new int[10];
            Random m = new Random();
            potoki Task1 = new potoki(() => Potok());
            for (int i = 0; i < mus1.Length; i++)
            {
                mus1[i] = m.Next(1, 10);
                Console.Write($"{mus1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < mus2.Length; i++)
            {
                mus2[i] = m.Next(1, 10);
                Console.Write($"{mus2[i]} ");
            }





        }
        public static void Potok()
        {







        }

    }
}
