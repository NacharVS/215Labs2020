﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.buildings
{
    class Shahta : mainuint
    {
        public static int goldInSecond;
        public static int maxcount;
        public Shahta( int Health, int GoldInSecond, int Maxcount)
        {
            health = Health; goldInSecond = GoldInSecond; maxcount = Maxcount;
        }

        public static void klan()
        {
            Console.WriteLine($"Kол-во здоровья:{health}, максимальное кол-во ресурса: {maxcount}, скорость добычи: {goldInSecond}");
            Console.WriteLine();
        }
    }
}
