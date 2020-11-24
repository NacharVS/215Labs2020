﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_mir_fermer : unit_abstract, ISpeed, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public Unit_mir_fermer(string name, int xp, double speed, int resorce)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Resource = resorce;
        }
    }
}
