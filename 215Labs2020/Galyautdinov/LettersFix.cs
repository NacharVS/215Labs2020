using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class LettesFix
    {
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                if (name[0].ToString() != name[0].ToString().ToUpper())
                {
                    name[0] = name[0].ToString().ToUpper();
                }
            }
        }
        public static void StudentInfo()
        {
            LettesFix lf = new LettesFix();
            lf.name = "ivan";
            Console.WriteLine(lf.name[0].ToString().ToUpper());
        }
    }
}

