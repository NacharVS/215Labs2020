using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.FriendlyGDIUnites
{
    class GDIHarvestr : UnitInfo, IntUnitsMovement, IntAttack, IntCredits
    {
        public GDIHarvestr(string name, int health, int damage, int range, int speed, int credits)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Range = range;
            Speed = speed;
            Credits = credits;
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} dealing damage: - {Damage} hp");
        }
        public void Movement()
        {
            Console.WriteLine($"{Name} moves with speed: {Speed}");
        }
        public void PointsCredit()
        {
            Console.WriteLine($"{Name} collecting credits: {Credits}");
        }
    }
}
