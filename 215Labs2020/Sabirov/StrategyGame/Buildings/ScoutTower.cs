using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Buildings
{
    class ScoutTower : Building, IBuildingTime, IProduction
    {
        public ScoutTower(int health, int armour)
        {
            ScoutTower.Armour = armour;
            ScoutTower.Health = health;
        }

        public void Time()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            System.Threading.Thread.Sleep(13000);
            Console.WriteLine($"Gold(ScoutTower): {Unit.Gold + 550}");


        }

    }
}
