using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame.Wars
{
    class pehotinec : mainuint, Iwar
    {
        public static int damage;
        public static string gun;
        public pehotinec(string Name, int Health, int Radius, string Gun, int Damage)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; damage = Damage;
        }

        public void war()
        {
            Console.WriteLine($"Имя воина:{name}, кол-во здоровья:{health}, радиус действия:{radius}, кол-во особого урона: {damage}, оружие: {gun}");
            Console.WriteLine("Сильный воин, умеело орудующий мечом");
            Console.WriteLine();
        }
    }
}
