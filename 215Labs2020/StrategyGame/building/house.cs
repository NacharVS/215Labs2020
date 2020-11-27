using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class house : Unit, IHealth, IArmor
    {
        public house()
        {
        }

        public house(int _health, int _armor)
        {
            Health = _health;
            Armor = _armor;
        }

        void IArmor.Armor()
        {
            throw new NotImplementedException();
        }

        void IHealth.Health()
        {
            throw new NotImplementedException();
        }
    }
}
