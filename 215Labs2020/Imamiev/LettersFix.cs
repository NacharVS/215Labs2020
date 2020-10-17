using _215Labs2020.Imamiev;
using System;

namespace _215Labs2020.Imamiev
{
    class StudentMarks
    {
        public string name;
        public int math;
        public int info;
        public int physics;
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
        public int Physics
        {
            get
            {
                return physics;
            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) physics = value;
            }
        }
        public static void Marks()
        {
            Console.WriteLine("Введите кол-во студентов!");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                StudentMarks stud = new StudentMarks();
                Console.WriteLine("Введите имя студента");
                stud.Name = Console.ReadLine();
                Console.WriteLine("Введите оценку по математике");
                stud.Math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике");
                stud.Info = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                stud.Physics = int.Parse(Console.ReadLine());
                Console.WriteLine($"Имя студента: {stud.Name},Математика:{stud.Math},Информатика: {stud.Info},Физика:{stud.Physics })))");


            }
        }

    }
}
