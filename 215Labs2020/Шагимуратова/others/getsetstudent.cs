using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова
{
    class Stud
    {
        public string F;
        private int Math;
        private int Rus;
        private int Bio;

        public int _Math
        {
            get
            {
                return Math;
            }
            set
            {
                if (value <= 2)
                {
                    Math = 2;
                }
                if (value >= 5)
                {
                    Math = 5;
                }
                else Math = value;
            }
        }
        public int _Bio
        {
            get
            {
                return Bio;
            }
            set
            {
                if (value <= 2)
                {
                    Bio = 2;
                }
                if (value >= 5)
                {
                    Bio = 5;
                }
                else Bio = value;

            }
        }
        public int _Rus
        {
            get
            {
                return Rus;
            }
            set
            {
                if (value <= 2)
                {
                    Rus = 2;
                }
                if (value >= 5)
                {
                    Rus = 5;
                }
                else Rus = value;

            }
        }

    }
    class Program
    {
        public static void STUD()
        {
            Console.WriteLine("Введите количество студентов");
            var i = int.Parse(Console.ReadLine());
            Stud[] stud = new Stud[i];


            for (int k = 0; k < i; k++)
            {
                stud[k] = new Stud();
                Console.WriteLine("Введите Фамилию студента");
                string fam = Console.ReadLine();
                stud[k].F = fam;

                Console.WriteLine("Введите оценку по математике");
                int v = int.Parse(Console.ReadLine());
                stud[k]._Math = v;

                Console.WriteLine("Введите по русскому");
                var r = int.Parse(Console.ReadLine());
                stud[k]._Rus = r;


                Console.WriteLine("Введите по биологии");
                var b = int.Parse(Console.ReadLine());
                stud[k]._Bio = b;

                Console.WriteLine($"{stud[k].F} - математика {stud[k]._Math} , русский язык {stud[k]._Rus} , биология {stud[k]._Bio} ");
            }

        }
    }


}

