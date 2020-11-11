using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class BranchOffice
    {
        public static int Task1(int[] array)
        {
          int max = 0;
          for (int i = 0; i < array.Length; i++)
          {
            if (max < array[i])
            {
              max = array[i];
            }

          }
            return max;  
        }
        public static void Task2()
        {


        }
    }
}
