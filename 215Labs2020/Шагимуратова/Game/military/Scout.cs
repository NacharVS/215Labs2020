using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game.military
{
    class Scout : All_Unit
    {
        private int _distanse_visibiliti;
        private int _time_hide;//максимальное время для того чтобы юнит спрятался

     

        public int Distanse_visibiliti { get => _distanse_visibiliti; set => _distanse_visibiliti = value; }
        public int Time_hide { get => _time_hide; set => _time_hide = value; }
    }
}
