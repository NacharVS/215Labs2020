﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class StringOperations
    {
        //public static string letters = "Two sailors are walking down the seashore, one of them says: Actually, i'm not even a sailor";
        public static string letters = "Жили-были дед да бабка";

        public static void LetQua(string s)
        {
            Console.WriteLine(s);
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

            
        }
    }
}
