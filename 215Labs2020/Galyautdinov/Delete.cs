using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class Delete
    {
        
            public string name;
            public static void StudentInfo()
            {
                Student std1 = new Student();
                std1.name = "ivan";
                Console.Write(std1.name[0].ToString().ToUpper());
                for (int i = 1; i < std1.name.Length; i++)
                {
                    Console.Write(std1.name[i]);
                }

            }
        
    }
}
