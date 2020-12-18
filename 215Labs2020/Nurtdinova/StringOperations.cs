using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova
{
    class StringOperations
    {
        public static void k(string m)
        {
            Console.WriteLine(m.Length);
        }

        public static void probeli(string s)
        {

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.Write(item + ' ');
            }
        }

        public static void z3(string m)
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
