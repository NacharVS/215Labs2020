using _215Labs2020.Imamov.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov
{
    class General
    {
        public static int[] array1 = new int[5];
        public static int[] array2 = new int[5];
        public static void Operations()
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 9);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 9);
            }
            Console.Write("Your first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            Console.Write("Your second array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose option:");
            Console.WriteLine("1.The maximum element of the array");
            Console.WriteLine("2.Sum of array elements");
            Console.WriteLine("3.Filtered arrey");
            Console.WriteLine("4.Sum of two arrays");
            Console.WriteLine("5.Substruction of two arrays");
            Console.WriteLine("6.Multiplication of two arrays");
            Console.WriteLine("7.Exit");
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                a = 7;
            }
            while (a < 7)
            {
                switch (a)
                {
                    case 1:
                        BranchOffice.Max_Elem();
                        break;
                    case 2:
                        BranchOffice.Sum_Of_El();
                        break;
                    case 3:
                        BranchOffice.Filt();
                        break;
                    case 4:
                        BranchOffice.Sum_Of_Arr();
                        break;
                    case 5:
                        BranchOffice.Substract();
                        break;
                    case 6:
                        BranchOffice.Multiply();
                        break;
                }
                Console.WriteLine();
                try
                {
                    Console.Write("Choose next option: ");
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    a = 7;
                }
            }
        }
    }
}
