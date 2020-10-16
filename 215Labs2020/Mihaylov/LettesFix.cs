using System;
namespace 215Labs2020.Mihaylov
{
    class LetterFix
    {
        public string name;
        public int math;
        public int inf;
        public int his;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
            String d = value;
            string b = d[0].ToString().ToUpper();
            string c = d.TrimStart(new char[] { d[0] });
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

                if (value <= 5 || value >= 2) math = value;
            }
        }
        public int Info
        {
            get
            {
                return inf;
            }
            set
            {

                if (value <= 5 || value >= 2) inf = value;
            }
        }
        public int Phisics
        {
            get
            {
                return his;
            }
            set
            {


                if (value <= 5 || value >= 2) his = value;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество студентов:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                LetterFix stud = new LetterFix();
                Console.WriteLine("Введите имя студента");
                stud.Name = Console.ReadLine();
                Console.WriteLine("Введите оценку по математике");
                stud.Math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике");
                stud.Info = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                stud.Phisics = int.Parse(Console.ReadLine());
                Console.WriteLine($"Имя студента: {stud.Name}, Математика: {stud.Math}, Информатика: {stud.Info}, Физика: {stud.Phisics}");

            }

        }
    }
}