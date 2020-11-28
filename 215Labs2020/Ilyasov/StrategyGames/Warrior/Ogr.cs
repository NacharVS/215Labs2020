using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.StrategyGames.Warrior
{
    class Ogr : Abstract, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Ogr(int xp, double speed, int damage)
        {
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"Огр атаковал с уроном: {Damage} ");
        }
        public void Move()
        {
            Console.WriteLine($"Огр движется со скоростью: {Speed} км/ч");
        }
    }
}
