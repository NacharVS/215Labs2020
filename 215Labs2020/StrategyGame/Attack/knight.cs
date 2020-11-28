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
        public void proverka()
        {
            knight c = new knight(12,13,35,57);
            Console.WriteLine("урон knight ");
            double a = int.Parse(Console.ReadLine());
            if (a >= 10 || a <= 2000) knight.Damage = 0;
            Console.WriteLine("враг убит");
        }
        public void proverka2()
        {
            builder c = new builder(12, 13);
            Console.WriteLine("скорость builder ");
            double a = int.Parse(Console.ReadLine());
            if (a >= 10 || a <= 2000) builder.Speed = 0;
            Console.WriteLine("builder ходит");
        }
    }
}
