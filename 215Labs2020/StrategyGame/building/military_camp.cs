using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class military_camp : Unit, IHealth, IArmor
    {
        public military_camp()
        {
        }

        public military_camp(int _health, int _armor)
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
