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
    interface Movement
    {
        public int Speed { get; }
        public void Movemen();
    }
    interface Productivity
    {
        public int Gold { get; }

        public void product();
    }
    interface Radius
    {
        public int Radius { get; }

        public void Rad();
    }
    interface Ikazarma
    {
        public int Voinkol { get; }

        public void VoinKol();
    }
}