using System;

namespace _215Labs2020.Ilyasova
{
    class StudentGetSet1
    {
        
        private string name;
        private int izo;
        private int history;
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
        public int Izo
        {
            get
            {
                return izo;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) izo = value;
            }
        }
        public int History
        {
            get
            {
                return history;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) history = value;
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
            Console.WriteLine("Колличество студентов:");
            int a = int.Parse(Console.ReadLine());
            StudentGetSet1[] array = new StudentGetSet1[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = new StudentGetSet1();
                Console.WriteLine("Введите имя студента");
                array[i].Name = Console.ReadLine();
                Console.WriteLine("Оценка по изо:");
                array[i].Izo = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по иcтории:");
                array[i].History = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                array[i].Phisics = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Имя студента: {array[i].Name}, Изо: {array[i].Izo}, История: {array[i].History}, Физика: {array[i].Phisics})))");
            }
        }
    }
}

    

