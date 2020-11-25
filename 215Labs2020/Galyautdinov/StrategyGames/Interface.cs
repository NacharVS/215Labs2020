using System;

namespace _215Labs2020.Galyautdinov.StrategyGames
{
    interface IAttack
    {
        public int Damage { get; }
        public void Attack();
    }
    interface IMovable
    {
        public double Speed { get; }
        public void Move();
    }
    interface IHeight
    {
        public int Damage { get; }
        public double height { get; }

        public void Height();
    }
    interface IResource
    {
        public int Resource { get; }

        public void Res();
    }
    interface IWork
    {
        public int Hours { get; }

        public void Work();
    }
    interface IRadius
    {
        public double Radius { get; }

        public void Rad();
    }
    interface IKuznitsa
    {
        public int Kol { get; }

        public void Kuz_kol();
    }
    interface IKazarma
    {
        public int Voin_kol { get; }

        public void VoinKol();
    }
}
