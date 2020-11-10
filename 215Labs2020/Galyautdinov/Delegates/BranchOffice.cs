using System;

namespace _215Labs2020.Galyautdinov.Delegates
{
    class BranchOffice
    {
        private delegate void Action(int mes);
        private delegate void Action1(string mes);

        public static void max()
        {
            Action max;
            max = GeneralOffice.Max_el_array;
            int max1 = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                if (General.array1[i] > max1)
                {
                    max1 = General.array1[i];
                }
            }
            max(max1);
        }
        public static void sum()
        {
            Action sum;
            sum = GeneralOffice.Sum_el_array;
            int sum1 = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                sum1 += General.array1[i];
            }
            sum(sum1);
        }
        public static void sort()
        {
            Action1 sort;
            sort = GeneralOffice.Sort_el_array;
            int buf = 0;
            for (int i = 0; i < General.array1.Length; i++)
            {
                for (int j = 1; j < General.array1.Length - i; j++)
                {
                    if (General.array1[j - 1] > General.array1[j])
                    {
                        buf = General.array1[j];
                        General.array1[j] = General.array1[j - 1];
                        General.array1[j - 1] = buf;
                    }
                }
            }
            string array12 = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                array12 += $"{General.array1[i]} ";
            }
            sort(array12);
        }
        public static void sumArray()
        {
            Action1 sum_array;
            sum_array = GeneralOffice.SumArray;
            int[] array12 = new int[General.array1.Length];
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = General.array1[i] + General.array2[i];
            }
            string massiv = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                massiv += $"{array12[i]} ";
            }
            sum_array(massiv);
        }
        public static void sub_el_array()
        {
            Action1 sub_array;
            sub_array = GeneralOffice.Sub_el_array;
            int[] array12 = new int[General.array1.Length];
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = General.array1[i] - General.array2[i];
            }
            string string_array12 = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                string_array12 += $"{array12[i]} ";
            }
            sub_array(string_array12);
        }
        public static void com_el_array()
        {
            Action1 com_array;
            com_array = GeneralOffice.Com_el_array;
            int[] array12 = new int[General.array1.Length];
            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = General.array1[i] * General.array2[i];
            }
            string string_array12 = "";
            for (int i = 0; i < General.array1.Length; i++)
            {
                string_array12 += $"{array12[i]} ";
            }
            com_array(string_array12);
        } 
    }
}
