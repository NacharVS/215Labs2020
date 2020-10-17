using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin
{
    class students
    {
        public string name;
        public int prorammy;
        public int math;
        public int history;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                string a = value;
                string b = a[0].ToString().ToUpper();
                string c = a.TrimStart(new char[] { a[0] });
                name = b + c;
            }
        }
        public int programmy
        {
            get
            {
                return programmy;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) programmy = value;
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
        public static void StudentsMarks()
        {
            Console.WriteLine("Введите кол-во студентов!");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                students stud = new students();
                Console.WriteLine("Введите имя студента");
                stud.Name = Console.ReadLine();
                Console.WriteLine("Введите оценку по программированю");
                stud.programmy = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по математике");
                stud.math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по истории");
                stud.history = int.Parse(Console.ReadLine());
                Console.WriteLine($"Имя студента:")






            }
        }



 
    }
}
