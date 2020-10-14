using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class Student
    {
        public string name;
        public double score;
        //public string math;
        //public string rus;
        //public string inf;
        public double scoreMath;
        public double ScoreMath
        {
            get
            {
                return scoreMath;
            }
            set
            {
                if (value < 2)
                    scoreMath = 2;
                else if (value > 5)
                    scoreMath = 5;
                else
                    scoreMath = value;
            }
        }
        public double scoreRus;
        public double ScoreRus
        {
            get
            {
                return scoreRus;
            }
            set
            {
                if (value < 2)
                    scoreRus = 2;
                else if (value > 5)
                    scoreRus = 5;
                else
                    scoreRus = value;
            }
        }
        public double scoreInf;
        public double ScoreInf
        {
            get
            {
                return scoreInf;
            }
            set
            {
                if (value < 2)
                    scoreInf = 2;
                else if (value > 5)
                    scoreInf = 5;
                else
                    scoreInf = value;
            }
        }
        public static void A(int n, int m)
        {
            Student[] StudentName = new Student[6];
            for (int i = 0; i < StudentName.Length; i++)
            {
                StudentName[i] = new Student();
            }
            Console.Write("Введите количество студентов: ");
            int col = int.Parse(Console.ReadLine());
            for (int k = 0; k < col; k++)
            {
                Console.Write($"{k + 1}) Введите Фвмилию Имя студента: ");
                StudentName[k].name = Console.ReadLine();
                Console.Write("   Введите оценку по математике: ");
                StudentName[k].ScoreMath = int.Parse(Console.ReadLine());
                Console.Write("   Введите оценку по информатике: ");
                StudentName[k].ScoreInf = int.Parse(Console.ReadLine());
                Console.Write("   Введите оценку по русскому языку: ");
                StudentName[k].ScoreRus = int.Parse(Console.ReadLine());
                StudentName[k].score = Math.Round(((StudentName[k].ScoreMath + StudentName[k].ScoreRus + StudentName[k].ScoreInf) / 3), 2);
                Console.WriteLine();
            }
            int maxx = 0;
            for (int i = 0; i < col; i++)
            {
                if (StudentName[i].name.Length > maxx)
                    maxx = StudentName[i].name.Length;
            }

            Console.Write("Введите минимальный проходной балл: ");
            double minScore = double.Parse(Console.ReadLine());
            Console.WriteLine();
            int l = 0;
            for (int i = 0; i < StudentName.Length; i++)
            {
                if (minScore <= StudentName[i].score)
                {
                    l++;
                    int a1 = maxx + 4;
                    int c1 = 7;
                    if (l == 1)
                    {
                        Console.Write("№ | Фамилия Имя  ");
                        for (int h = 1; h < a1 - 2; h++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("| Средний балл  ");
                        for (int h = 1; h < c1; h++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("| Оценка по математике | Оценка по информатике | Оценка по русскоу языку |");
                        Console.WriteLine();
                        Console.Write("__|");
                        for (int h = 1; h < a1 + 12; h++)
                        {
                            Console.Write("_");
                        }
                        Console.Write("|");
                        for (int h = 1; h < 22; h++)
                        {
                            Console.Write("_");
                        }
                        Console.Write("|______________________|_______________________|_________________________|");
                        Console.WriteLine();
                    }
                    if (l > 1)
                    {
                        Console.Write("--|");
                        for (int h = 1; h < a1 + 12; h++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("|");
                        for (int h = 1; h < 22; h++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("|----------------------|-----------------------|-------------------------|");
                        Console.WriteLine();
                    }
                    int a = maxx + 15 - StudentName[i].name.Length;
                    Console.Write($"{l} | {StudentName[i].name}");
                    for (int h = 1; h < a; h++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"| {StudentName[i].score}");
                    int c = 21 - Convert.ToString(StudentName[i].score).Length;
                    for (int h = 1; h < c; h++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine($"|          {StudentName[i].ScoreMath}           |           { StudentName[i].ScoreInf}           |            { StudentName[i].ScoreRus}            |");
                }
            }

            for (int h = 1; h < maxx + 20; h++)
            {
                Console.Write("-");
            }
            for (int h = 1; h < 23; h++)
            {
                Console.Write("-");
            }
            Console.Write("-------------------------------------------------------------------------");
            Console.WriteLine();
            if (l == 0)
            {
                Console.WriteLine("Cтудентов с таким баллом нет");
            }
            Console.ReadKey();
        }
    }
}
