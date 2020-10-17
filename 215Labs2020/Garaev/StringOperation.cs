using System;
using System.Collections.Generic;
using System.Text;

namespace String_operation
{
    class StringOperation
    {
        public static void col_bukv(string a)
        {
            int col = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char s = a[i];
                if (Convert.ToString(s) == " ")
                {
                    col++;
                }
            }
            col = a.Length - col;
            Console.WriteLine(col);
        }//1-е задание
    }
}
