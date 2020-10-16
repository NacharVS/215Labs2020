using System;
namespace _215Labs2020.Mihaylov
{
    class DayOfBirthBonus
    {
        public string name;
        public int day;
        public int month;
        public int year;
        public static int ball = 0;
        public static int addedpoints()
        {
            ball += 1000;
            return ball;
        }
        public static void Main(string[] args)
        {
            DayOfBirthBonus birthDay = new DayOfBirthBonus();
            DayOfBirthBonus birthMonth = new DayOfBirthBonus();
            DayOfBirthBonus birthYear = new DayOfBirthBonus();
            DayOfBirthBonus names = new DayOfBirthBonus();
            DayOfBirthBonus regs = new DayOfBirthBonus();
            Console.WriteLine("Пройдите регистрацию");
            Console.WriteLine("Введите ваше ФИО:");
            names.name = Console.ReadLine();
            Console.WriteLine("Введите день вашего рождения:");
            birthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения:");
            birthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год вашего рождения:");
            birthYear.year = int.Parse(Console.ReadLine());
            if (birthDay.day == DateTime.Now.Day & birthMonth.month == DateTime.Now.Month)
            {
                addedpoints();
                Console.WriteLine($"Сейчас вам {DateTime.Now.Year - birthYear.year} лет, вы еще молоды.");
            }
            Console.WriteLine($"Вы имеете {ball} баллов");
            Console.WriteLine("Спасибо за регистрацию");
        }
    }
}