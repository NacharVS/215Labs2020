using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy
{
    abstract class AbsarctClassVse : IAttack
    {
        public static int XP { get; set; }

        public void Attack()
        {
            Console.WriteLine("атакует");
        }

    }
}
