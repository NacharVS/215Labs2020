using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class General
    {
      public delegate int BranchOffice(int[] array);
      public delegate int GeneralOffice(int[] array1, int[] array2);



        public static void Ex1()
        {
            Random rnd = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 15);
                array2[i] = rnd.Next(0, 15);
            }
            Console.Write("mass1:  ");
           

           
        }
        
      
       
      

    }
}
