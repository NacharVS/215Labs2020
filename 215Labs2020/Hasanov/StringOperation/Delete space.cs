using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.StringOperation
{
    class Delete_space
    {
        
        public static void DC() 
        {
            Console.WriteLine("Введите строку");
            string StringName = Console.ReadLine();
            string[] arry = StringName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i] + ' ');

            }
        }
    }   



}   
    



    






    
