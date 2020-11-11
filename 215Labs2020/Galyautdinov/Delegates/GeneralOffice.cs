using System;

namespace _215Labs2020.Galyautdinov.Delegates
{
    class GeneralOffice
    {
        public static void Max_el_array(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                }
            }
            Console.WriteLine($"Максимальный элемент массива: {max}");
        }
        public static void Sum_el_array(int[] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
        public static void Sort_el_array(int[] mass)
        {
            int buf = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 1; j < mass.Length - i; j++)
                {
                    if (mass[j - 1] > mass[j])
                    {
                        buf = mass[j];
                        mass[j] = mass[j - 1];
                        mass[j - 1] = buf;
                    }
                }
            }
            int[] mass1 = new int[mass.Length];
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass1[i] += mass[i];
                Console.Write(mass1[i] + " ");
            }
            Console.WriteLine();

        }
        public static void SumArray(int[] mass, int[] mass1)
        {
            int[] array12 = new int[mass.Length];
            Console.Write("Сумма элементов двух массива: ");
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = mass[i] + mass1[i];
                Console.Write(array12[i]+ " ");
            }
        }
        public static void Sub_el_array(int[] mass, int[] mass1)
        {
            Console.WriteLine();
            int[] array12 = new int[mass.Length];
            Console.Write("Разнсть двух массивов: ");
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = mass[i] - mass1[i];
                Console.Write(array12[i] + " ");
            }  
        }
        public static void Com_el_array(int[] mass, int[] mass1)
        {
            Console.WriteLine();
            Console.Write("Произведение двух массивов: ");
            int[] array12 = new int[mass.Length];
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = mass[i] * mass1[i];
                Console.Write(array12[i] + " ");
            }
        }
    }
}
