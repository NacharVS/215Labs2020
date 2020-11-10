using System;
using _215Labs2020.Imamov;

namespace _215Labs2020.Imamov.Delegates
{
    class BranchOffice
    {
        delegate void Trainee(int result);
        delegate void Act(string res);
        public static void Max_Elem()
        {
            int max = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                if (General.array1[i] > max)
                {
                    max = General.array1[i];
                }
            }
            Trainee tr1;
            tr1 = GeneralOffice.Maximum_Element;
            tr1(max);
        }
        public static void Sum_Of_El()
        {
            int sum = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                sum += General.array1[i];
            }
            Trainee tr1;
            tr1 = GeneralOffice.Sum_Of_Elements;
            tr1(sum);
        }
        public static void Filt()
        {
            int num = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                for (int b = 1; b < General.array1.Length - i; b++)
                {
                    if (General.array1[b-1]> General.array1[b])
                    {
                        num = General.array1[b];
                        General.array1[b] = General.array1[b - 1];
                        General.array1[b - 1] = num;
                    }
                }
            }
            string array = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                array += $"{General.array1[i]} ";
            }
            Act tr1;
            tr1 = GeneralOffice.Filter;
            tr1(array);
        }
        public static void Sum_Of_Arr()
        {
            int[] array = new int[General.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = General.array1[i] + General.array2[i];
            }
            string arr = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr1;
            tr1 = GeneralOffice.Sum_Of_Arrays;
            tr1(arr);
        }
        public static void Substract()
        {
            int[] array = new int[General.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = General.array1[i] - General.array2[i];
            }
            string arr = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr1;
            tr1 = GeneralOffice.Substraction;
            tr1(arr);
        }
        public static void Multiply()
        {
            int[] array = new int[General.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = General.array1[i] * General.array2[i];
            }
            string arr = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr1;
            tr1 = GeneralOffice.Multiplication;
            tr1(arr);
        }
    }
}
