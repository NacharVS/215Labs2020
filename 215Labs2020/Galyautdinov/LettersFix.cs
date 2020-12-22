using System;

namespace _215Labs2020.Galyautdinov
{
    class LettesFix
    {
        private static string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();//Для обрезки начальных или концевых символов используется функция Trim
                _name = value[0].ToString().ToUpper() + value.Substring(1);
            }
        }
        public static void StudentInfo()
        {
            LettesFix lf = new LettesFix();
            lf.name = Console.ReadLine();
            Console.WriteLine(lf.name);
        }
    }
}

