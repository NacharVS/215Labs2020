using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.Bashnya
{
    class BashnyaMagazin : Abstract, IResource
    {
        public int Resource { get; private set; }

        public BashnyaMagazin(string name, int xp, int resource1)
        {
            Name = name;
            Xp = xp;
            Resource = resource1;
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }
    }
}
