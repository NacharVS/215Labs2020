using System;
using System.Collections.Generic;
using System.Text;


namespace _215Labs2020.Ibragimov
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            string letters = "предложение просто";
            Console.WriteLine(letters.Length);
            string letters1 = "          предложение       просто";
            Console.WriteLine(letters.Length);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(Regex.Replace(letters1, "[ ]+", " "));
            Console.WriteLine(letters1);
        }
    }
}
 