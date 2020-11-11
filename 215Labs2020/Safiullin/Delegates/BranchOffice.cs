using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class BranchOffice
    {
        public static void Task1(int[] mass)
        {
            static void Main(string[] args)
            {
                int[] array = { 15, 16, 23, -10, 0, 5 };
                int max = Max(array);
                Console.Write(max);
                Console.ReadKey();

            }
            static int Max(int[] array)
            {
                int max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }

                }
                return max;
            }
        }
        public static void Task2()
        {

        }
    }
}
