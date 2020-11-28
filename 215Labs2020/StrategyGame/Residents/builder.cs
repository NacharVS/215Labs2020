using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class builder : Unit, IHealth, ISpeed
    {
        public builder()
        {
        }

        public builder( int _health, int _speed)
        {
            Health = _health;
            Speed = _speed;

        }


        void IHealth.Health()
        {
            throw new NotImplementedException();
        }

        void ISpeed.Speed()
        {
            throw new NotImplementedException();
        }
        public void proverka2()
        {
            builder c = new builder(12, 13);
            Console.WriteLine("скорость builder ");
            double a = int.Parse(Console.ReadLine());
            if (a >= 10 || a <= 2000) builder.Damage = 0;
            Console.WriteLine("builder ходит");
        }
    }
}
