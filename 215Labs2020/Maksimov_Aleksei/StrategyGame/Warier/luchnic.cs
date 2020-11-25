using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class luchnic : mainuint
    {
        public int countOfArrow { get; private set; }
        public string gun { get; private set; }
        public luchnic(string Name, int Health, int Radius, string Gun, int CountOfArrow)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; countOfArrow = CountOfArrow;
        }
    }
}
