using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class knight : Unit , IDamage, IHealth, ISpeed, IArmor
    {
        public knight()
        {
        }
        public int a { get; private set; }

        public knight(int _damage, int _health,int _speed, int _armor)
        {
            knight.Damage= _damage;
            knight.Health = _health;
            knight.Speed = _speed;
            knight.Armor = _armor;

        }


        void IDamage.Damage()
        {
            throw new NotImplementedException();
        }

       

        void IArmor.Armor()
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
