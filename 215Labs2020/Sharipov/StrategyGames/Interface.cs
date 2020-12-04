using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames
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
    interface IBolnisa
    {
        public int Bol { get; }

        public void bolychka();
    }
}
