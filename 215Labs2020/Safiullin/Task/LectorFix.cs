using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class LectorFix
    {
      
        private string name;
        private int mark1;
        private int mark2;
        private int mark3;
        public int Mark1
        {
            get { return mark1; }
            set
            {
                if (value < 2) { mark1 = 2; }
                else if (value > 5) { mark1 = 5; }
                else { mark1 = value; }
            }
        }

        public int Mark2
        {
            get { return mark2; }
            set
            {
                if (value < 2) { mark2 = 2; }
                else if (value > 5) { mark2 = 5; }
                else { mark2 = value; }
            }
        }
        public int Mark3
        {
            get { return mark3; }
            set
            {
                if (value < 2) { mark3 = 2; }
                else if (value > 5) { mark3 = 5; }
                else { mark3 = value; }

            }
        }
        public static void StudentRegister()
        {
            LectorFix[] mass = new LectorFix[5];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new LectorFix();
                Console.Write("Введите Фамилию Имя ученика: ");
                mass[i].name = Console.ReadLine();
                Console.Write("Введите оценку по математике: ");
                mass[i].Mark1 = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по русскому языку: ");
                mass[i].Mark2 = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по английскому: ");
                mass[i].Mark3 = int.Parse(Console.ReadLine());
                Console.WriteLine("____________________________________");
                bool b = true;
                for (int j = 0; j < mass[i].name.Length; j++)
                {
                    if (b) { Console.Write(mass[i].name[j].ToString().ToUpper()); b = false; }
                    else { Console.Write(mass[i].name[j]); };
                    string c = Convert.ToString(mass[i].name[j]);
                    switch (c)
                    {
                        case " ": b = true; break;
                    }
                }
                Console.WriteLine($"    {mass[i].Mark1}    {mass[i].Mark2}    {mass[i].Mark3}");
                Console.WriteLine("____________________________________");
            }
        }
    }
}
