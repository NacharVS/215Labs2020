using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _215Labs2020.Шагимуратова
{
    class async
    {
        public static void Mainmethod()
        {
            int[] mass1 = new int[10];
           
            int[] mass2 = new int[10];
      
            int[] mass3 = new int[10];
           
            AsyncSum(mass1, mass2, mass3);
            Console.WriteLine("Enter the number of items");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < item; i++)
            {
                Console.WriteLine(mass3[i]);
            }

        }

        public static void AsyncMass(int[] mass1, int[] mass2, int[] mass3)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(1,100) ;
            }
            Random rnd2 = new Random();
            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = rnd2.Next(1, 100);
            }
            Random rnd3 = new Random();
            for (int i = 0; i < mass3.Length; i++)
            {
                mass3[i] = mass1[i] + mass2[i];
            }
        }
        
    }
}