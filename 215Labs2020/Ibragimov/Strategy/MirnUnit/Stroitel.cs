using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class Stroitel : AbsarctClassVse, ISkorost, IStroit,IMirn
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public short Stroit { get; private set; }
        public Stroitel(int xp, double speed, int damage, short stroit)
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
            Stroit = stroit;
        }
        public void Mirn1()
        {
            Console.WriteLine($"имеет хп {XP}  атака {Damage} скорость  {Speed} строит {Stroit} ");


        }
    }
}
