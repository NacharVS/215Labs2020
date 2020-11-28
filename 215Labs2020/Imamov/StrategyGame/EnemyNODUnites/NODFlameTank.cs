using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.EnemyNODUnites
{
    class NODFlameTank : UnitInfo, IntUnitsMovement, IntAttack
    {
        public NODFlameTank(string name, int health, int damage, int range, int speed)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Range = range;
            Speed = speed;
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} is dealing damage: - {Damage} hp");
        }
        public void Movement()
        {
            Console.WriteLine($"{Name} is moving with speed: {Speed}");
        }
    }
}
