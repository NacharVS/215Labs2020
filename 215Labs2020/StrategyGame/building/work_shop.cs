using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class work_shop : Unit, IHealth, IArmor
    {
        public work_shop()
        {
        }

        public work_shop(int _health, int _armor)
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
