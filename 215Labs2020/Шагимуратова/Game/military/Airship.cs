using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game.military
{
    class Airship : All_Unit
    {
        private int _height_fly;
        private int _tonnage;

        public int Height_fly { get => _height_fly; set => _height_fly = value; }
        public int Tonnage { get => _tonnage; set => _tonnage = value; }
    }
}
