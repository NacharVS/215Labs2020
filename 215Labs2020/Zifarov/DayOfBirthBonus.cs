using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov
{
    class DayOfBirthBonus
    {
        public string _name;
        public string _surname;
        public int _birthday;
        public int _birthmonth;
        public int _birthyear;
        public static int _personalBonus = 0;
        public static int _birthdayBonus = 1000;
        public static void BirthdayBonus(int birthday, int birthmonth, int birthyear, string name, string surname)
        {
            int a = DateTime.Now.Day;
            int b = DateTime.Now.Month;
            int c = DateTime.Now.Year;
            int age = 0;
            if (a == birthday & b == birthmonth) age = c - birthyear;
            if (a == birthday & b == birthmonth) Console.WriteLine($"{name} {surname}, поздравляем с вашим {age}летием,в честь праздника на ваш счет зачисленно 1000 баллов");
            if (a == birthday & b == birthmonth) Console.WriteLine($"На вашем бонусном счету теперь {_personalBonus = _birthdayBonus + _personalBonus}");
            else Console.WriteLine($"Спасибо за регистрацию, на вашем счету {_personalBonus} баллов, всего хорошего!");
        }

        public static void Registr()
        {
            Console.WriteLine("Добрый день, пожалуйста пройдите простую регистрацию в нашем магазине.");
            Console.WriteLine("Назовите свое имя");
            DayOfBirthBonus person = new DayOfBirthBonus();
            person._name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            person._surname = Console.ReadLine();
            Console.WriteLine("Введите день месяца своего рождения");
            person._birthday = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения");
            person._birthmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год своего рождения");
            person._birthyear = int.Parse(Console.ReadLine());
            DayOfBirthBonus.BirthdayBonus(person._birthday, person._birthmonth, person._birthyear, person._name, person._surname);
        }
    }
}
