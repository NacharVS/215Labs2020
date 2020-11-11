using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Delegate
{
    class GeneralOffice
    {
        public static void Max_Element(int result)
        {
            Console.WriteLine
                ($"Максимальный элемент массива {result}");
        }
        public static void Summ_Of_Element(int result)
        {
            Console.WriteLine
                ($"Сумма элементов массива { result}");
        }
        public static void Filter(string res)
        {
            Console.WriteLine
                ($"Отфильтрованный массив {res}");
        }
        public static void Summ_OfArrays(string res)
        {
            Console.WriteLine
                ($"Сумма двух массивов {res}");
        }
        public static void Substraction (string res)
        {
            Console.WriteLine
                ($"Cубстракция двух массивов {res}");
        }
        public static void Multiplication(string res)
        {
            Console.WriteLine
                ($"Умножение двух массивов {res}");
        }
    }
}
