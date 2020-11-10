using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Delegates
{
    class GeneralOffice
    {

        public static void sum()
        {
            int[] mas = new int[2];
            Random rnd = new Random(0);
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 2);
                sum += mas[i];
            }
        } 




    }
}
