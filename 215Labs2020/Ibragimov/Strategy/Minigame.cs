using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy
{
    class Minigame
    {
        public static void mingame()
        {
            IMirn mir;
            IVoin voi;
            IZdanie zd;
            voi = new AtackUnit.Arbaletcshik(5, 6.5, 7);
            voi.Voin1();

            voi = new AtackUnit.Bomber(5, 6.5, 7);
            voi.Voin1();


            mir = new Unit.Farmer(5, 5.5, 5,5);
            mir.Mirn1();

            zd = new BuildUnit.ElixirStore(25, 5);
            zd.Zdanie1();

        }
    }
}

