using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    class DayOfBrithday
    {
        public string _name;
        public int _age;
        public int _Year;
      
        public int _personalBonus = 0;

    }
    public static void Bonus()
    {
        Console.WriteLine("Добрый день, пожалуйста пройдите простую регистрацию в нашем магазине.");
        Console.WriteLine("Назовите свое имя");
        DayOfBrithday person = new DayOfBrithday();
        person._name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        person._age = int.Parse(Console.ReadLine());
    }
    

    
}
