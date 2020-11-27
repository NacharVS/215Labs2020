using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Voiny
{
    class Luchnik : absract, Attack, Movement
    {
        public int Damage { get; private set; }
        public int Speed { get; private set; }
        public Luchnik(string name, int xp, int speed, int damage)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Урон: {Damage} ед.");
        }
        public void Movemen()
        {
            Console.WriteLine($"Скорость: {Speed} км/ч");
        }
    }
}