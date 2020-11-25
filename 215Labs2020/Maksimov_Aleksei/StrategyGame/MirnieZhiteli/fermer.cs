using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.MirnieZhiteli
{
    class fermer : mainuint
    {
        public string remeslo { get; private set; }
        public int timeOfWork { get; private set; }
        public fermer(string Name, int Health, int Radius, int TimeOfWork, string Remeslo)
        {
            name = Name; health = Health; radius = Radius; remeslo = Remeslo; timeOfWork = TimeOfWork;
        }
    }
}
