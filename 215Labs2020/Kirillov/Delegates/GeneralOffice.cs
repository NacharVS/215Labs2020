using System;


namespace _215Labs2020.Kirillov.Delegates
{
    class GeneralOffice
    {
        public static void Max_Elem(int[] array1)
        {
            int max = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                } 
            }
            Console.WriteLine($"The maximum element of the array : {max}");

        }
        public static void Sum_Of_El(int[] array1)
        {
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine($"Sum of array elements: {sum}");
        }
        public static void Filt(int[] array1)
        {
            int num = 0;
            for (int i = 0; i< array1.Length; i++)
            {
                for (int b = 1; b < array1.Length - i; b++)
                {
                    if (array1[b-1]> array1[b])
                    {
                        num = array1[b];
                        array1[b] = array1[b - 1];
                        array1[b - 1] = num;
                    }

                }
            }
            int[] arr1 = new int[array1.Length];
            Console.Write("Filtered array: ");
            for (int i = 0; i<array1.Length; i++)
            {
                arr1[i] += array1[i];
                Console.Write(arr1[i] + " ");
            }
            Console.Writeline();
        }
        public static void Sum_Of_Arr(int[] array1, int [] array2)
        {
            int[] array3 = new int[array1.Length];
            Console.Write("Sum of two arrays: ");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Substract(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length];
            Console.Write("Substruction of two arrays: ");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] - array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Multiply(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length];
            Console.Write("Multiplicftion of two arrays: ");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
