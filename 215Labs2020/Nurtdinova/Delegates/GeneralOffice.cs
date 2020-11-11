using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.Delegates
{
    class GeneralOffice
    {
        public static void MaxElement()
        {
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(mass);
            int maxValue = mass[mass.Length - 1];
            Console.WriteLine(maxValue);
        }
        public static void SortirovkaMass()
        {
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i; i < mass.Length; j++)
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
        public static void SummElMass()
        {
            int[] mass = new int[5];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = mass[i] + sum;
            }
            Console.WriteLine("SUM={0},sum");
        }
        public static void SummMass()
        {
            Console.WriteLine("Заполните первый массив");
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Заполните второй массив");
                int[] mass2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass2[{0}]=", i);
                mass2[i] = int.Parse(Console.ReadLine());
            }
            int[] sum = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sum[i] = mass[i] + mass2[i];
            }
            Console.WriteLine("Сумма масивов");
            foreach (var v in sum)
                Console.WriteLine(v);
        }
        public static void RaznMass()
        {
            Console.WriteLine("Заполните первый массив");
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Заполните второй массив");
            int[] mass2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass2[{0}]=", i);
                mass2[i] = int.Parse(Console.ReadLine());
            }
            int[] sum = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sum[i] = mass[i] + mass2[i];
            }
            Console.WriteLine("Разность масивов");
            foreach (var v in sum)
                Console.WriteLine(v);
        }
        public static void MultMass()
        {
            Console.WriteLine("Заполните первый массив");
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass[{0}]=", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Заполните второй массив");
            int[] mass2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mass2[{0}]=", i);
                mass2[i] = int.Parse(Console.ReadLine());
            }
            int[] mult = new int[5];
            for (int i = 0; i < 5; i++)
            {
                mult[i] = mass[i] + mass2[i];
            }
            Console.WriteLine("Умножение масивов");
            foreach (var v in mult)
                Console.WriteLine(v);
        }

    }



}


