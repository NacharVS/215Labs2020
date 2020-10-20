using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Davletshina
{
    class Lab1
    {
        class Student
        {
            public string name;
            public double score;
            public double scoreMath;
            public double scoreProgrammy;
            public double scoreInformation;
        }
        public static void p(int b)
        {
            Student[] StudentName = new Student[5];
            for (int i = 0; i < StudentName.Length; i++)
            {
                StudentName[i] = new Student();
            }
            StudentName[0].name = "Abramov Nikita";
            StudentName[0].scoreMath = 4;
            StudentName[0].scoreProgrammy = 5;
            StudentName[0].scoreInformation = 5;
            StudentName[0].score = Math.Round(((StudentName[0].scoreMath + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation)/3),2);
            StudentName[1].name = "Pavlov Marat";
            StudentName[1].scoreMath = 5;
            StudentName[1].scoreProgrammy = 5;
            StudentName[1].scoreInformation = 5;
            StudentName[1].score = Math.Round(((StudentName[0].scoreMath + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation) / 3), 2);
            StudentName[2].name = " Aminova Alina";
            StudentName[2].scoreMath = 4;
            StudentName[2].scoreProgrammy = 4;
            StudentName[2].scoreInformation = 5;
            StudentName[2].score = Math.Round(((StudentName[0].scoreMath + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation) / 3), 2);
            StudentName[3].name = "Ivanov Pavel";
            StudentName[3].scoreMath = 3;
            StudentName[3].scoreProgrammy = 3;
            StudentName[3].scoreInformation = 4;
            StudentName[3].score = Math.Round(((StudentName[0].scoreMath + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation) / 3), 2);
            StudentName[4].name = "Petrova Angelina";
            StudentName[4].scoreMath = 5;
            StudentName[4].scoreProgrammy = 4;
            StudentName[4].scoreInformation = 5;
            StudentName[4].score = Math.Round(((StudentName[0].scoreMath + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation) / 3), 2);
            Console.Write("Enter the minimal score:");
            double minScore = double.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < StudentName.Length; i++)
            {
                if (minScore <= StudentName[i].score)
                {
                    a++;
                    Console.WriteLine($"Name and Last name:{StudentName[i].name} Average score: { StudentName[i].score}");
                }
            }
            if (a==0)
            {
                Console.WriteLine("These are no students wich such a score!");
            }
        }
    }
}
