using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Delegate
{
    class BranchOffice
    {
        delegate void Trainee(int result);
        delegate void Act(string res);
        public static void Max_Elem()
        {
            int max = 0;
            for (int i = 0; i < Program.array1.length; i++)
            {
                if (Program.array1[i] > max)
                {
                    max = Program.array1[i];
                }
            }
            Trainee tr1;
            tr1 = GeneralOffice.Max_Element;
            tr1(max);
        }
        public static void Sum_Of_E1()
        {
            int sum = 0;
            for (int i = 0; i < Program.array1.Length; i++)
            {
                sum += array1[1];
            }
            Trainee tr1;
            tr1 = GeneralOffice.Summ_Of_Element;
            tr1(sum);
        }
        public static void Filt()
        {
            int num = 0;
            for (int i = 0; i < Program.array1.length; i++)
            {
                for (int b = 1; b < Program.array1.length - i; b++)
                {
                    if (Program.array1[b - 1] > Program.array1[b])
                    {
                        num = Program.array1[b];
                        Program.array1[b] = Program.array1[b - 1];
                        Program.array1[b - 1] = num;
                    }
                }
            }
            string array = "";
            for(int i = 0; i < Program.array1.Length; i++)
            {
                array += $"{Program.array1[i]}";
            }
            Act tr1;
            tr1 = GeneralOffice.Filter;
            tr1(array);
        }
        public static void Sum_Of_Arr()
        {
            int[] array = new int[Program.array1.length];
            for (int i = 0; i <array.Length; i++)
            {
                array[i] = Program.array1.Length;i++);
            }
        }
    }
}
