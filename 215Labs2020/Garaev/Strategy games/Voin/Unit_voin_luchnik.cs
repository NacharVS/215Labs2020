using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_voin_luchnick : unit_abstract, ISpeed, IDalnost
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public int Dalnost { get; private set; }

        public Unit_voin_luchnick(string name, int xp, double speed, int damage, int dalnost)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
            Dalnost = dalnost;
        }
        public void dalnost()
        {
            Console.WriteLine($"Воин нанес урон {Damage} с дальности: {Dalnost} м.");
        }
        public void scorost()
        {
            Console.WriteLine($"Воин движется со скоростью: {Speed} км/ч");
        }
    }
}
