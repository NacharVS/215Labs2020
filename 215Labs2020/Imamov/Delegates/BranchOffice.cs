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
            for (int i = 0; i < Program.array1.Length; i++)
            {
                if (Program.array1[i] > max)
                {
                    max = Program.array1[i];
                }
            }
            Trainee tr1;
            tr1 = GeneralOffice.Maximum_Element;
            tr1(max);
        }
        public static void Sum_Of_El()
        {
            int sum = 0;
            for (int i = 0; i < Program.array1.Length; i++)
            {
                sum += Program.array1[i];
            }
            Trainee tr1;
            tr1 = GeneralOffice.Sum_Of_Elements;
            tr1(sum);
        }
        public static void Filt()
        {
            int num = 0;
            for (int i = 0; i < Program.array1.Length; i++)
            {
                for (int b = 1; b < Program.array1.Length - i; b++)
                {
                    if (Program.array1[b-1]> Program.array1[b])
                    {
                        num = Program.array1[b];
                        Program.array1[b] = Program.array1[b - 1];
                        Program.array1[b - 1] = num;
                    }
                }
            }
            string array = "";
            for (int i = 0; i < Program.array1.Length; i++)
            {
                array += $"{Program.array1[i]} ";
            }
            Act tr1;
            tr1 = GeneralOffice.Filter;
            tr1(array);
        }
        public static void Sum_Of_Arr()
        {
            int[] array = new int[Program.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Program.array1[i] + Program.array2[i];
            }
            string arr = "";
            for (int i = 0; i < Program.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr2;
            tr2 = GeneralOffice.Sum_Of_Arrays;
            tr2(arr);
        }
        public static void Substract()
        {
            int[] array = new int[Program.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Program.array1[i] - Program.array2[i];
            }
            string arr = "";
            for (int i = 0; i < Program.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr2;
            tr2 = GeneralOffice.Substraction;
            tr2(arr);
        }
        public static void Multiply()
        {
            int[] array = new int[Program.array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Program.array1[i] * Program.array2[i];
            }
            string arr = "";
            for (int i = 0; i < Program.array1.Length; i++)
            {
                arr += $"{array[i]} ";
            }
            Act tr2;
            tr2 = GeneralOffice.Multiplication;
            tr2(arr);
        }
    }
}
