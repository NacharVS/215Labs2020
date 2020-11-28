using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.EnemyNODUnites
{
    class NODSoldiers : UnitInfo, IntUnitsMovement, IntAttack
    {
        public NODSoldiers(string name, int health, int damage, int range, int speed)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Range = range;
            Speed = speed;
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} are dealing damage: - {Damage} hp");
        }
        public void Movement()
        {
            Console.WriteLine($"{Name} are moving with speed: {Speed}");
        }
    }
}
