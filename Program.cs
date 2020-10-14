using System;

namespace ConsoleApp1
{
    class Register
    {
        public string name;
        private int mark;
        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if (value > 5)
                {
                    mark = 5;
                }
                else if (value < 2)
                {
                    mark = 2;
                }
                else
                {
                    mark = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Register[] mass = new Register[5];
            Register[] ocenki = new Register[3];
            //Масив для хронения оценок по трем предметам
            for (int i = 0; i < ocenki.Length; i++)
            {
                ocenki[i] = new Register();
            }
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new Register();

            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("Введите Фамилию Имя ученика: ");
                mass[i].name = Console.ReadLine();
                Console.Write("Введите оценку по математике: ");
                ocenki[0].Mark = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по русскому языку: ");
                ocenki[1].Mark = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по английскому: ");
                ocenki[2].Mark = int.Parse(Console.ReadLine());
                Console.WriteLine("****************************************");
                Console.WriteLine($"{mass[i].name}    {ocenki[0].Mark}    {ocenki[1].Mark}    {ocenki[2].Mark}");
                Console.WriteLine("****************************************");
            }

        }
    }
}
