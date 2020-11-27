using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class seeker : Unit, IHealth, ISpeed
    {
        public seeker()
        {
        }

        public seeker(int _health, int _speed)
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
    }
}
