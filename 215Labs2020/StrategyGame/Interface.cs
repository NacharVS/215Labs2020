using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    interface IDamage
    {
        public void Damage();
    }
    interface IHealth
    {
        void Health();
    }
    interface ISpeed
    {
        void Speed();
    }
    interface IArmor
    {
        void Armor();
    }
}
