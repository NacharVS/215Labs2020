using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.FriendlyGDIUnites
{
    class GDISnipers : UnitInfo, IntUnitsMovement, IntAttack
    {
        public GDISnipers(string name, int health, int damage, int range, int speed)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Range = range;
            Speed = speed;
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} dealing damage: - {Damage} hp");
        }
        public void Movement()
        {
            Console.WriteLine($"{Name} moves with speed: {Speed}");
        }
    }
}
