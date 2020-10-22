//using System;
//namespace _215Labs2020.Mihaylov
//{
//    class StringOperations
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите слово");
//            string str = Console.ReadLine();
//            Console.WriteLine($"Количество символов в слове: {str.Length}");
//        }  
//    }
//}
//    static void Entriesn()
//    {
//        Console.WriteLine("Введите слово");
//        string str = Console.ReadLine();
//        str = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
//        Console.WriteLine(str);
//    }
//    static void OneTwo()
//    {
//    string two = "";
//    string one = "";
//    Console.WriteLine("Введите слово");
//    string a = Console.ReadLine();
//    string str = a.Replace(" ", "");

//    for (int i = 0; i < str.Length; i++)        
//            if (i % 2 == 0)
//            {
//                one += str[i] + "; ";
//            }
//            else
//            {
//                two += str[i] + "; ";
//            }
//    Console.WriteLine($"Нечетный: {one}");
//    Console.WriteLine($"Четный: {two}");
//    }