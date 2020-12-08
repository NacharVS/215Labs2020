using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game.military
{
    class Wizard:All_Unit
    {
        private Boolean _faerball ;
        private int _faerball_level;
        private int _faerball_power;

        

        public bool Faerball { get => _faerball; set => _faerball = value; }
        public int Faerball_level { get => _faerball_level; set => _faerball_level = value; }
        public int Faerball_power { get => _faerball_power; set => _faerball_power = value; }

    }
}
