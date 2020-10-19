using System;


namespace _215Labs2020.Sadukov
{
    class StringOperations
    {
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
