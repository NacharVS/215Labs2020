using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_voin_golem : unit_abstract, ISpeed, IAttack
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Unit_voin_golem(string name, int xp, double speed, int damage)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
        public void scorost()
        {
            Console.WriteLine($"Воин движется со скоростью: {Speed} км/ч");
        }
        public void Attack()
        {
            Console.WriteLine($"Атака Воина с уроном: {Damage} ед.");
        }
    }
}
