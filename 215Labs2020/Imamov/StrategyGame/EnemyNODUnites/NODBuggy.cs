using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.EnemyNODUnites
{
    class NODBuggy : UnitInfo, IntUnitsMovement, IntAttack
    {
        public NODBuggy(string name, int health, int damage, int range, int speed)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Range = range;
            Speed = speed;
        }
        public void Attack()
        {
            Console.WriteLine($"{NODBuggy.Name} dealing damage: - {Damage} hp");
        }
        public void Movement()
        {
            Console.WriteLine($"{NODBuggy.Name} moves with speed: {Speed}");
        }
    }
}
