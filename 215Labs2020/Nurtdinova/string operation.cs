using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _215Labs2020.Davletshina
{
    class string_operation
    {
        static void Main(string[] args)
        {
            string str = "Hello, my name is Liliya!";
            Console.WriteLine(str.Length);
            {
                Console.WriteLine(str);
                Console.WriteLine(Regex.Replace(str,"[ ]+"," "));
                {
                    string[] arr = str.Split("\n".ToCharArray());
                    for (int i = 1; i < arr.Length; i+=2)
                    {
                        Console.WriteLine(arr[i]);
                        Console.WriteLine(arr[i-1]);
                    }
                    if (arr.Length % 2 != 0)
                        Console.WriteLine(arr[arr.Length - 1]);
                }
            }
        }
    }
}
