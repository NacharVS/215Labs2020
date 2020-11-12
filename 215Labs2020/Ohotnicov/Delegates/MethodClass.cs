using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.Delegates
{
    class MethodClass
    {
        public static void MaxElement(int[] mass)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(mass);
            int maxValue = mass[mass.Length - 1];
            Console.WriteLine(maxValue);
        }
        public static void SortirovkaMass(int[] mass)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadLine();
        }
        public static void SummElMass(int[] mass)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.Write("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = mass[i] + sum;
            }
            Console.Write("sum = {0}", sum);
        }
        public static void SummMass(int[] mass, int[] mass2)
        {
            int[] summ = new int[5];
            for (int i = 0; i < 5; i++)
            {
                summ[i] = mass[i] + mass2[i];
            }
            Console.WriteLine("Сумма масивов");
            foreach (var v in summ)
                Console.WriteLine(v);
        }
        public static void SubMass(int[] mass, int[] mass2)
        {
            int[] summ = new int[5];
            for (int i = 0; i < 5; i++)
            {
                summ[i] = mass[i] - mass2[i];
            }
            Console.WriteLine("Разность масивов");
            foreach (var v in summ)
                Console.WriteLine(v);

        }
        public static void MultMass(int[] mass, int[] mass2)
        {

            int[] mult = new int[5];
            for (int i = 0; i < 5; i++)
            {
                mult[i] = mass[i] * mass2[i];
            }
            Console.WriteLine("Умноженный массив");
            foreach (var v in mult)
                Console.WriteLine(v);

        }



    }
}
