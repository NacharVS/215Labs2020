﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaExpressions
{
    class program
    { 
        public delegate bool Positive(int x);
        public static int operation(Positive x, int y)
        {
            return y + 10;
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int Result = operation(x => x > 0, 5);
            Console.WriteLine(Result);
        }
    }
}
