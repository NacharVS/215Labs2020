using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class StringOperations
    {
        public static string letters = "Two sailors are walking down the seashore, one of them says: Actually, i'm not even a sailor";


        public static void LetQua(string s)
        {
            Console.WriteLine(s.Length);
        }

        public static void Enters(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.Write(item + ' ');
            }

        }
        public static void EvenAndNot(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"This letter is even: {s[i]}");
                }

                if (i % 2 != 0)
                {

                    Console.WriteLine($"And this letter is not: {s[i]}");
                }

            }

        }
    }
}
