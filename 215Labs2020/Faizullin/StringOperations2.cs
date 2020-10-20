using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class StringOperations2
    {
        public static void PROBEL(string b)
        {
            string[] words = b.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.WriteLine(item + ' ');
            }
        }
    }
}
