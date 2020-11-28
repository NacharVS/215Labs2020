using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _215Labs2020.Ilyasov
{
    class LettersFix
    {
        public string name;
        public int russ;
        public int math;
        public int infa;

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
                name = b + c; ;
            }
        }
        public int Russ
        {
            get
            {
                return russ;
            }
            set
            {
                if (value > 5) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) russ = value;
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
                if (value > 5) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) math = value;
            }
        }
        public int Infa
        {
            get
            {
                return infa;
            }
            set
            {
                if (value > 5) value = 5;
                if (value < 2) value = 2;
                if (value <= 5 || value >= 2) infa = value;
            }
        }
        public static void BD()
        {
            Console.WriteLine("Введите сколько студентов");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                LettersFix stud = new LettersFix();
                Console.WriteLine("Введите имя");
                stud.Name = Console.ReadLine();
                Console.WriteLine("Введите оценку по математике");
                stud.Math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по русскому");
                stud.Russ = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по информатике");
                stud.Infa = int.Parse(Console.ReadLine());
                Console.WriteLine($"Его зовут : {stud.Name}, Оценка по математике : {stud.Math}, по русскому : {stud.Russ}, по информатике : {stud.Infa}");

            }
        }

    }
}
