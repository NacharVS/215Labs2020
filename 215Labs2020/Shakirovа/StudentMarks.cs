using System;


namespace _215Labs2020.Shakirovа
{
    class StudentMarks
    {
        public string Surname;
        private int Math;
        private int Rus;
        private int Eng;

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

        public int _Eng
        {
            get
            {
                return Eng;
                 
            }
            set
            {
                if (value <= 2)
                {
                    Eng = 2;
                }
                if (value >= 5)
                {
                    Eng = 5;
                }
                else Eng = value;

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            var i = int.Parse(Console.ReadLine());
            StudentMarks[] stud = new StudentMarks[i];

            for (int k = 0; k < i; k++)
            {
                stud[k] = new StudentMarks();
                Console.WriteLine("Enter the student's Surname ");
                string fam = Console.ReadLine();
                stud[k].Surname = fam;

                Console.WriteLine("Enter math mark");
                int v = int.Parse(Console.ReadLine());
                stud[k]._Math = v;

                Console.WriteLine("Enter Russian mark");
                var r = int.Parse(Console.ReadLine());
                stud[k]._Rus = r;

                Console.WriteLine("Enter English mark");
                var b = int.Parse(Console.ReadLine());
                stud[k]._Eng = b;

                Console.WriteLine($"{stud[k].Surname} - Math {stud[k]._Math} , Russian {stud[k]._Rus} ,English {stud[k]._Eng} ");
            }

        }
    }

}

