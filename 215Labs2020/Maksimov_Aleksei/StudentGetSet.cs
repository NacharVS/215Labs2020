using System;

namespace _215Labs2020.Maksimov_Aleksei
{
    class StudentGetSet
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
                name = value;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество студентов!)");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                StudentGetSet stud = new StudentGetSet();
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
