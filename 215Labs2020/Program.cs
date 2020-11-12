using _215Labs2020.Ohotnicov;
using _215Labs2020.Ohotnicov.Delegates;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _215Labs2020
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Заполните первый массив");
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("mass[{0}]=", i);
               mass[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Заполните второй массив(если вы работаете с одним массивом, то напишите везде - 1)");
            int[] mass2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("mass2[{0}]=", i);
                mass2[i] = int.Parse(Console.ReadLine());
            }
            DelegateClass.metod1(mass);
            DelegateClass.metod2(mass, mass2);
        }
    }
}
