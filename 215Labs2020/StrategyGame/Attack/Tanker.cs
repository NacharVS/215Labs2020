using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Tanker : Unit, IDamage, IHealth,ISpeed, IArmor
    {
        public Tanker()
        {
        }

        public Tanker(int _damage, int _health, int _speed,int _armor)
        {
            Damage = _damage;
            Health = _health;
            Speed = _speed;
            Armor = _armor;
        }

        void IArmor.Armor()
        {
            throw new NotImplementedException();
        }

        void IDamage.Damage()
        {
            throw new NotImplementedException();
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
