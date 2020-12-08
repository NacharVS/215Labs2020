using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game.peaceful
{
    class Miner:All_Unit
    {
        private int _capacity_resourses;
        private int _speed_extraction;

        public int Capacity_resourses { get => _capacity_resourses; set => _capacity_resourses = value; }
        public int Speed_extraction { get => _speed_extraction; set => _speed_extraction = value; }
    }
}
