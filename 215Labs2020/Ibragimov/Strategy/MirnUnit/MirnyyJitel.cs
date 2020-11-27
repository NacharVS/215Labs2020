using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class MirnyyJitel : AbsarctClassVse , IMirn
    {
        public MirnyyJitel(int xp)
        {
            XP = xp;
        }
        public void Mirn1()
        {
            Console.WriteLine($"имеет хп {XP}  ");


        }

    }
}
