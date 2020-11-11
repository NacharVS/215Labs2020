using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class General
    {
      public delegate int BranchOffice(int[] array);
        public static void Ex1()
        {
            int[] rrrrr = new int[6] { 1, 2, 2, 3, 46, 7 };
            BranchOffice mass1;
            mass1 = Delegates.BranchOffice.Task1;
            Console.WriteLine(mass1(rrrrr));
        }
        
      
       
      

    }
}
