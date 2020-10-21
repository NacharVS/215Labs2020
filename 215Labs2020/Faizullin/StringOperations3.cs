using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class StringOperations3
    {
        public static void STRINGSSSSS(string m)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < m.Length; i++)
            {
                if (i % 2 == 0) a += m[i].ToString();
                else b += m[i].ToString();
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
