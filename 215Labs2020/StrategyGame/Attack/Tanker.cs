using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Tanker : Unit, IDamage, IHealth
    {
        public Tanker()
        {
        }

        public Tanker(int _damage, int _health, int _speed)
        {
            knight.Damage = _damage;
            knight.Health = _health;
            knight.Speed = _speed;
        }

        void IDamage.Damage()
        {
            throw new NotImplementedException();
        }

        void IHealth.IHealth()
        {
            throw new NotImplementedException();
        }
    }
}
