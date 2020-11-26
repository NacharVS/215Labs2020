using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.buildings
{
    class BStart
    {
        public static void zapuskB()
        {
            HouseOfBuilders ha = new HouseOfBuilders(50, "stone", 9);
            HouseOfBuilders.ho();
            KlanovoeZdanie kl = new KlanovoeZdanie(67, 400, 12);
            KlanovoeZdanie.klan();
            ScladResursov scl = new ScladResursov(100, 350, 350);
            ScladResursov.sk();
            Shahta sh = new Shahta(50, 30, 700);
            Shop j = new Shop(1000, "Products", "Knifes", "Clothing");
            Shop.shop();
        }
    }
}
