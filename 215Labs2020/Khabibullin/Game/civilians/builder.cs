using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game.civilians
{
    class builder : mainunit, Imzh
    {
        public static int speedOfBuilding;
        public static string instrument;
        public builder(string Name, int Health, int SpeedOfBuilding, string Instrument)
        {
            name = Name; health = Health; speedOfBuilding = SpeedOfBuilding; instrument = Instrument;
        }

        public void Mzh()
        {
            Console.WriteLine($"Имя строителя: {name}, кол-во здоровья: {health}, скорость постройки: {speedOfBuilding} зданий в неделю, рабочий инструмент: {instrument}");
            Console.WriteLine("Строитель строит защитные сооружения и дома для простых жителей");
            Console.WriteLine();
        }


    }
}
      
