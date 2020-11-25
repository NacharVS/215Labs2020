using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class pehotinec : mainuint
    {
        public int damage;
        public string gun { get; private set; }
        public pehotinec(string Name, int Health, int Radius, string Gun, int Damage)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; damage = Damage;
        }
    }
}
