using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.AtackUnit
{
    class Bomber:AbsarctClassVse, IAttack, ISkorost,IVoin
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }


        public Bomber(int xp, double speed, int damage )
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
        }
        public  void Voin1()
        {
            Console.WriteLine($"имеет хп {XP}  атака {Damage} скорость {Speed} ");

        }
    }
}
