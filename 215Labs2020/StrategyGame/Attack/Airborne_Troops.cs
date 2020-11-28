using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Airborne_Troops : Unit, IDamage , IHealth ,ISpeed, IArmor 
    {
        public Airborne_Troops()
        {
        }

        public Airborne_Troops(int _damage, int _health, int _speed, int _armor)
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
        public  void Attak()
        {
            Console.WriteLine("Airborne_Troops damage");
        }
        public void Go()
        {
            Console.WriteLine("Airborne_Troops speed");
        }
        //public void proverka()
        //{
        //    Airborne_Troops c = new Airborne_Troops(12, 13, 35, 57);
        //    Console.WriteLine("введите урон");
        //    Console.ReadLine();
        //    Console.WriteLine("враг убит");
        //}



    }
}
