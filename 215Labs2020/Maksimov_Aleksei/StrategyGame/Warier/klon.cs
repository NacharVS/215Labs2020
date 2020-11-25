using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class klon : mainuint
    {
        public int countKlon { get; private set; }
        public string gun { get; private set; }

        public klon(string Name, int Health, int Radius, string Gun, int Countklon)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; countKlon = Countklon;
        }

    }
}
