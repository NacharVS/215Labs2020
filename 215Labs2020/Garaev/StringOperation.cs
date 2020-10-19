using System;

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
                if (Convert.ToString(s) != " ")
                {
                    col++;
                }
            }
            Console.Write("Количество букв: ");
            Console.WriteLine(col);
        }
        public static void delete_probel(string a)
        {

            int col = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char s = a[i];
                if (Convert.ToString(s) == " ")
                {
                    col++;
                    if (col > 0)
                        a = a.Replace("  ", " ");
                }
                else
                    col = 0;
            }
            Console.Write("Этот же текст без лишних пробелов: ");
            Console.WriteLine(a);
        }
        public static void chet_nechet_bukv(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                char s = a[i];
                if (Convert.ToString(s) == " ")
                {
                    a = a.Replace(" ", "");
                }
            }
            string chet = "";
            string nechet = "";
            int chet_col = 0;
            int nechet_col = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char s = a[i];
                if (i % 2 == 0)
                {
                    nechet_col++;
                    if (nechet_col > 1)
                    {
                        nechet += ", " + s;
                    }
                    else
                        nechet += s;

                }
                else
                {
                    chet_col++;
                    if (chet_col > 1)
                    {
                        chet += ", " + s;
                    }
                    else
                        chet += s;
                }
            }
            Console.Write("Четные буквы: ");
            Console.WriteLine(chet);
            Console.Write("Нечетные буквы: ");
            Console.WriteLine(nechet);
        }
    }
}
