using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class bronenosec : mainuint
    {
        public int speed { get; private set; }
        public int armour { get; private set; }
        public string gun { get; private set; }
        public bronenosec(string Name, int Health, int Radius, string Gun, int Armour, int Speed)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; speed = Speed; armour = Armour;
        }
    }
}
