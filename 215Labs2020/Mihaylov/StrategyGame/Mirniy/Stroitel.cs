using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Mirniy
{
    class Stroitel : absract, Movable, Resource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public Stroitel(int xp, double speed, int resource)
        {
            Xp = xp;
            Speed = speed;
            Resource = resource;
        }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }


    }
}