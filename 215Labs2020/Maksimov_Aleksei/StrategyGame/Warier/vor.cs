using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class vor : mainuint
    {
        public int spaceInBackpack { get; private set; }
        public string gun { get; private set; }
        public vor(string Name, int Health, int Radius, string Gun, int SpaceInBackpack)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; spaceInBackpack = SpaceInBackpack;
        }
    }
}
