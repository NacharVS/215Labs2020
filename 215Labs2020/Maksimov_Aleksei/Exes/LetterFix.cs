using System;
using System.Collections.Specialized;

namespace _215Labs2020.Maksimov_Aleksei
{
    class LetterFix
    {
        private string name;
        private int math;
        private int info;
        private int phisics;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                String d = value;
                string b = d[0].ToString().ToUpper();
                string c = d.TrimStart(new char[] { d[0] });
                name = b + c;
            }
        }
        public int Math
        {
            get
            {
                return math;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) math = value;
            }
        }
        public int Info
        {
            get
            {
                return info;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) info = value;
            }
        }
        public int Phisics
        {
            get
            {
                return phisics;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) phisics = value;
            }
        }
        public static void SGS()
        {
            Console.WriteLine("Введите колличество студентов!)");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                LetterFix stud = new LetterFix();
                Console.WriteLine("Введите имя студента");
                stud.Name = Console.ReadLine();
                Console.WriteLine("Введите оценку по математике");
                stud.Math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике");
                stud.Info = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                stud.Phisics = int.Parse(Console.ReadLine());
                Console.WriteLine($"Имя студента: {stud.Name}, Математика: {stud.Math}, Информатика: {stud.Info}, Физика: {stud.Phisics})))");
            }
        }
    }
}