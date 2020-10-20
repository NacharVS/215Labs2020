using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.StringOperation
{
    public static class EvenOddLatter
    {
        public static void EOL()
        {
            Console.WriteLine("Введите строку");
            string StringName = Console.ReadLine();
            string one = "";
            String two = "";
            StringName = StringName.Replace(" ", "");
            for (int i = 0; i < StringName.Length; i++)
            {
                if (i % 2 == 0) one = one + StringName[i].ToString();
                else two = two + StringName[i].ToString();
            }
            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
