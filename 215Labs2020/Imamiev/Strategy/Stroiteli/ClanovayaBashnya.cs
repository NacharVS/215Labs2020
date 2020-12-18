using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Strategy.Stroiteli
{
    class ClanovayaBashnya:maininput, Ibuilding1
    {
        public static int maxCountOfGold;
        public ClanovayaBashnya(int Health, int MaxCountOfGold, int LevelOfBuilding)
        {
            health = Health; maxCountOfGold = MaxCountOfGold; levelOfBuilding = LevelOfBuilding;
        }
        public void build1()
        {
            Console.WriteLine($"Kол-во здоровья: {health}, максимальный размер хранилища: {maxCountOfGold}, уровень постройки: {levelOfBuilding}");
            Console.WriteLine();
        }
    }
}
