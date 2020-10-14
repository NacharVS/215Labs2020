using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov
{
    class practicGetSet
    {
        private string name;
        private int math;
        private int pe;
        private int art;
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
                if (value <= 5) math = value;
                if (value >= 2) math = value;

            }

        }
        public int Pe
        {
            get
            {
                return pe;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) pe = value;
                if (value >= 2) pe = value;

            }

        }
        public int Art
        {
            get
            {
                return art;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) art = value;
                if (value >= 2) art = value;

            }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество студентов");
            int kol = int.Parse(Console.ReadLine());
            double sred = 0;
            practicGetSet[] ocenki = new practicGetSet[kol];
            for (int i = 0; i < ocenki.Length; i++)
            {
                ocenki[i] = new practicGetSet();
            }
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (i < kol + 1) Console.WriteLine("Введите имя ученика");
                if (i < kol + 1) ocenki[i].Name = Console.ReadLine();
                if (i < kol + 1) Console.WriteLine("Введите оценки по математике");
                if (i < kol + 1) ocenki[i].Math = int.Parse(Console.ReadLine());
                if (i < kol + 1) Console.WriteLine("Введите оценку по физре");
                if (i < kol + 1) ocenki[i].Pe = int.Parse(Console.ReadLine());
                if (i < kol + 1) Console.WriteLine("Введите оценку по рисванию");
                if (i < kol + 1) ocenki[i].Art = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Введите необходимый средний бал");
            double ball = double.Parse(Console.ReadLine());
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (i < kol + 1) sred = ocenki[i].Math + ocenki[i].Pe + ocenki[i].Art;
                if (i < kol + 1) sred = sred / 3;
                if (ball <= sred) Console.WriteLine($"{ocenki[i].Name}    {sred}");
            }


        }
    }
}
