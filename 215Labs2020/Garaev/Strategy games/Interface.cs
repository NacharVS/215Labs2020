using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    interface IAttack
    {
        public int Damage { get; }
        public void Attack();
    }
    interface ISpeed
    {
        public double Speed { get; }
        public void scorost();
    }
    interface IHeight
    {
        public int height { get; }
        public void Height();
    }
    interface IResource
    {
        public int Resource { get; }
        public void Res();
    }
    interface IDalnost
    {
        public int Dalnost { get; }
        public void dalnost();
    }
}
