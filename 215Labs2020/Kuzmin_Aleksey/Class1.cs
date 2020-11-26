using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Class1
    {
        public delegate bool Posistive(int x);
        public static int Operation(Posistive x, int y)
        {
            return y + 10;
        }
        
        public static void Program()
        {
            int x = int.Parse(Console.ReadLine());
            int Result = Operation(x => x > 0, x) ;
            Console.WriteLine(Result);
        }
        
    }
}
