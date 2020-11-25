using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame
{
    interface Attack
    {
        public int Damage { get; }
        public void Attack();
    }
    interface Movable
    {
        public double Speed { get; }
        public void Move();
    }
    interface Resource
    {
        public int Resource { get; }

        public void Res();
    }
    interface Radius
    {
        public double Radius { get; }

        public void Rad();
    }
    interface Ikazarma
    {
        public int Voinkol { get; }

        public void VoinKol();
    }
}