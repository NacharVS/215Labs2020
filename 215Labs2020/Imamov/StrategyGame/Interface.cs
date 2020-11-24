using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame
{
    interface AIAttack
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"Hero attacked and damaged enemie: {Damage} hp ");
        }
    }
    interface AIMovement
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"Hero's movement speed: {Speed}");
        }
    }
    interface AIHeight
    {
        public int Damage { get; }
        public double height { get; }
        public void Height()
        {
            Console.WriteLine($"Hero damaged enemie {Damage} at height: {height}");
        }
    }
    interface AIResource
    {
        public int Treasure { get; }
        public void Trs()
        {
            Console.WriteLine($"Treasure: {Treasure} gold");
        }
    }
}
