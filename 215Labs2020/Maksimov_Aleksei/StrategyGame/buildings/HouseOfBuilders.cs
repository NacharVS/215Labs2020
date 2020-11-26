using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.buildings
{
    class HouseOfBuilders : mainuint
    {
        public static string stroyMaterial;
        public HouseOfBuilders(int Health, string StroyMaterial, int LevelOfBuilding)
        {
             health = Health; stroyMaterial = StroyMaterial; levelOfBuilding = LevelOfBuilding;
        }

        public static void ho()
        {
            Console.WriteLine($"Кол-во здоровья:{health}, строительный материал: {stroyMaterial}, уровень постройки: {levelOfBuilding}");
            Console.WriteLine();
        }
    }
}
