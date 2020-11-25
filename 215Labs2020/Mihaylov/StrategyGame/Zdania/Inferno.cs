using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Inferno : absract, Attack
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Inferno(string name, int xp, int damage)
        {
            Name = name;
            Xp = xp;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Атаковал с уроном: {Damage} ед.");
        }
    }
}