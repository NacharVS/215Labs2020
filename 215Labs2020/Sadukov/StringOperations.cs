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
        public static void Characters(string s)
        {
            Console.WriteLine(s.Length);
        }
        public static void EvenAndNot(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {


                for (int i = 0; i < item.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Четные буквы {item[i]}");
                    }

                    if (i % 2 > 0)
                    {

                        Console.WriteLine($"Нечетные буквы {item[i]}");
                    }

                }
            }

        }
    }
}
