using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame.buildings
{
    class HouseOfBuilders : mainuint, Ibuilding1
    {
        public static string stroyMaterial;
        public HouseOfBuilders(int Health, string StroyMaterial, int LevelOfBuilding)
        {
             health = Health; stroyMaterial = StroyMaterial; levelOfBuilding = LevelOfBuilding;
        }

        public void build1()
        {
            Console.WriteLine($"Кол-во здоровья: {health}, строительный материал: {stroyMaterial}, уровень постройки: {levelOfBuilding}");
            Console.WriteLine();
        }
    }
}
