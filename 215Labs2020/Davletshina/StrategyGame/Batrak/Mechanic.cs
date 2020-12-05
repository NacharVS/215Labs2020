﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Davletshina.StrategyGame.Batrak
{
    class Mechanic
    {
        public double Strength { get; private set; }
        public int Fantasy { get; private set; }

        public Mechanic(double strength, int fantasy)
        {
            Strength = strength;
            Fantasy = fantasy;
        }
    }
}
