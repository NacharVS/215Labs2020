using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_mir_Cook : unit_abstract, IResource, ISpeed
    {
        
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public Unit_mir_Cook(string name, int xp, double speed, int resorce)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Resource = resorce;
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы (еда): {Resource}");
        }
        public void scorost()
        {
            Console.WriteLine($"Работает с скоростью: {Speed} ед.");
        }
    }
}
