using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.MirnieZhiteli
{
    class builder : mainuint
    {
        public int speedOfBuilding { get; private set; }
        public string instrument { get; private set; }
        public builder(string Name, int Health, int Radius, int SpeedOfBuilding, string Instrument)
        {
            name = Name; health = Health; radius = Radius; speedOfBuilding = SpeedOfBuilding; instrument = Instrument;
        }
    }
}
