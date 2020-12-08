using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game.military
{
    class Shooter : All_Unit
    {
        private int _distanse_shoot;
        private int _level_gun;
        private string _gun_name;
public int Distanse_shoot { get => _distanse_shoot; set => _distanse_shoot = value; }
        public int Level_gun { get => _level_gun; set => _level_gun = value; }
        public string Gun_name { get => _gun_name; set => _gun_name = value; }
    }

        
    
}
