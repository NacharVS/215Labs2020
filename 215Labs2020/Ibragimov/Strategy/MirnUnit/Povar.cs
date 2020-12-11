using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class Povar :AbsarctClassVse, ISkorost, Igotovka,IMirn
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public double  Gotovka { get; private set; }

        public Povar ( int xp, double speed, int damage, int gotovka)
        {
            
            XP = xp;
            Speed = speed;
            Damage = damage;
            Gotovka = gotovka;
        }

        public void Mirn1()
        {
            Console.WriteLine($"имеет хп {XP}  атака {Damage} скорость  {Speed} готовит {Gotovka} ");


        }

    }
}
