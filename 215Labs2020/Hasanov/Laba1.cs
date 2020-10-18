using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    public class Laba1
    {
        private string name;
        private int bio;
        private int his;
        private int math;
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
                string one = value;
                string two = one[0].ToString().ToUpper();
                string three = one.TrimStart(new char[] { one[0] });
                name = two + three;

            }

        }
        public int Bio
        {
            get
            {
                return bio;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) bio = value;
                if (value >= 2) bio = value;

            }

        }
        public int His
        {
            get
            {
                return his;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) his = value;
                if (value >= 2) his = value;

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





        public static void PSGS()
        {
            Console.WriteLine("Введите количество студентов");
            int kol = int.Parse(Console.ReadLine());
            double sred = 0;
            LetterFix[] ocenki = new LetterFix[kol];
            for (int i = 0; i < ocenki.Length; i++)
            {
                ocenki[i] = new LetterFix();
            }
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (i < kol + 1) Console.WriteLine("Введите имя ученика");
                if (i < kol + 1) ocenki[i].Name = Console.ReadLine();
                if (i < kol + 1) Console.WriteLine("Введите оценки по математике");
                if (i < kol + 1) ocenki[i].Bio = int.Parse(Console.ReadLine());
                if (i < kol + 1) Console.WriteLine("Введите оценку по физре");
                if (i < kol + 1) ocenki[i].His = int.Parse(Console.ReadLine());
                if (i < kol + 1) Console.WriteLine("Введите оценку по рисованию");
                if (i < kol + 1) ocenki[i].Math = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Введите необходимый средний бал");
            double ball = double.Parse(Console.ReadLine());
            for (int i = 0; i < ocenki.Length; i++)
            {
                if (i < kol + 1) sred = ocenki[i].bio + ocenki[i].his + ocenki[i].math;
                if (i < kol + 1) sred = sred / 3;
                if (ball <= sred) Console.WriteLine($"{ocenki[i].Name} оценка по математике {ocenki[i].Bio}, оценка по физре {ocenki[i].His}, оценки по рисованию {ocenki[i].Math}, средний бал {sred}");
            }
        }
