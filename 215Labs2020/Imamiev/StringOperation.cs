using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev
{
    class StringOperation
    {
        public static void lenghtOftext(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(s.Length);
        }
        public static void DeletingSpaces(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in words)
            {
                Console.WriteLine(item + ' ');
            }
        }
        public static void space(string s)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) a += s[i].ToString();
                else b += s[i].ToString();
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
