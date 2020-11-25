using System;

namespace _215Labs2020.Galyautdinov.StrategyGames.Bashnya
{
    class BashnyaKrepost : Abstract, IRadius, IResource
    {
        public double Radius { get; private set; }
        public int Resource { get; private set; }

        public BashnyaKrepost(string name, int xp, double radius1, int resource1)
        {
            Name = name;
            Xp = xp;
            Radius = radius1;
            Resource = resource1;
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }
        public void Rad()
        {
            Console.WriteLine($"наблюдает в радиусе: {Radius} м.");
        }
    }
}
