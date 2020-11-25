using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Airborne_Troops : Unit, IDamage , IHealth
    {
        public Airborne_Troops()
        {
        }

        public Airborne_Troops(int _damage, int _health, int _speed)
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
