using System;


namespace _215Labs2020.Ibragimov.Strategy
{
    interface IAttackUnit
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"персонаж атакует {Damage}");
        }
    }
    interface ISkorost
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"скорость персонажа составляет {Speed}");
        }
    }
     interface Igotovka
     {
        public double Gotovka { get; }
        public void Gotovit()
        {
            Console.WriteLine($"повар готовит единиц еды {Gotovka}");
        }
     }

    interface IDobychaRud
    {
        public double DobychaRuda { get; }
        public void Dobycha()
        {
            Console.WriteLine($" шахтер добывает руд {DobychaRuda}");
        }
    }

    interface IStroit
    {
        public short Stroit { get; }
        public void Stroitelstvo()
        {
            Console.WriteLine($" строитель строит  {Stroit}");
        }
    }
    interface ProizvodctvoEd
    {
        public int ProizvodctvoEda { get; }
        public void Eda1()
        {
            Console.WriteLine($" Фермер производит еды  {ProizvodctvoEda}");
        }
    }


    interface IZdanie
    {
        public void Zdanie1();
    }

    interface IMirn
    {
        public void  Mirn1 ();
    }

    interface IVoin 
    {
        public void Voin1();
    }
}

