
using System;

namespace _215Labs2020.Kirillov
{
    class StudentsMarksGetSet
    {
        private string name;
        private string surname;
        private int _eng;
        private int info;
        private int physics;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Eng
        {
            get
            {
                return _eng;
            }
            set 
            {
                if (value >= 6)
                    _eng = 5;
                else if (value < 2) 
                    _eng = 2;
                else 
                    _eng = value;
                 
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
        public int Physics
        {
            get
            {
                return physics;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) physics = value;
            }
        }

        public static void StudyMarks()
        {
            Console.WriteLine("Введите кол-во студентов");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                StudentsMarksGetSet std = new StudentsMarksGetSet();
                Console.WriteLine("Введите имя студента");
                std.Name = Console.ReadLine();
                Console.WriteLine("Введите фамили. студента");
                std.Surname = Console.ReadLine();
                Console.WriteLine("Введите оценку по английскому");
                std.Eng = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике");
                std.Info = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                std.Physics = int.Parse(Console.ReadLine());
                Console.WriteLine($"Имя и фамилия студента: {std.Name} {std.Surname}, Английский: {std.Eng}, Информатика: {std.Info}, Физика: {std.Physics}");
            }
        }
    }
}

