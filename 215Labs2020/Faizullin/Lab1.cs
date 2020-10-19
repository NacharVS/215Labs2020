using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class Lab1
    {
        class Student
        {
            public string name;
            public double score;
            public double scoreMathematics;
            public double scorePhysics;
            public double scoreInformation;
        }
        public static void p(int b)
        {
            Student[] StudentName = new Student[3];
            for (int i = 0; i < StudentName.Length; i++)
            {
                StudentName[i] = new Student();
            }
            StudentName[0].name = "Faizullin Azat";
            StudentName[0].scoreMathematics = 4;
            StudentName[0].scorePhysics = 5;
            StudentName[0].scoreInformation = 4;
            StudentName[0].score = Math.Round(((StudentName[0].scoreMathematics + StudentName[0].scorePhysics + StudentName[0].scoreInformation) / 3), 2);
            StudentName[1].name = "Ivanov Kirill";
            StudentName[1].scoreMathematics = 5;
            StudentName[1].scorePhysics = 4;
            StudentName[1].scoreInformation = 4;
            StudentName[1].score = Math.Round(((StudentName[1].scoreMathematics + StudentName[1].scorePhysics + StudentName[1].scoreInformation) / 3), 2);
            StudentName[2].name = "Nazarov Pavel";
            StudentName[2].scoreMathematics = 5;
            StudentName[2].scorePhysics = 5;
            StudentName[2].scoreInformation = 5;
            StudentName[2].score = Math.Round(((StudentName[2].scoreMathematics + StudentName[2].scorePhysics + StudentName[2].scoreInformation) / 3), 2);
            Console.Write("Enter the minimal score:");
            double minScore = double.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < StudentName.Length; i++)
            {
                if (minScore <= StudentName[i].score)
                {
                    a++;
                    Console.WriteLine($"Name and Last name: {StudentName[i].name} Average score: {StudentName[i].score}");
                }

            }
            if (a == 0)
            {
                Console.WriteLine("There are no students with such a score!");
            }
        }
    }
}
