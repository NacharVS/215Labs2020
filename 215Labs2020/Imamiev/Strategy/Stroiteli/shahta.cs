using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Strategy.Stroiteli
{
    class shahta : mainuint, Ibuilding1  
    {
        public static int goldInSecond;
        public static int maxcount;
        public shahta(int Health, int GoldInSecond, int Maxcount)
        {
            health = Health; goldInSecond = GoldInSecond; maxcount = Maxcount;
        }

        public void build1()
        {
            Console.WriteLine($"Kол-во здоровья:{health}, максимальное кол-во ресурса: {maxcount}, скорость добычи: {goldInSecond}");
            Console.WriteLine();
        }
    }
}
