﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game.enemies
{
    class vor : mainunit, Iwar
    {
        public static int spaceInBackpack;
        public static string gun;
        public vor(string Name, int Health, string Gun, int SpaceInBackpack)
        {
            name = Name; health = Health; gun = Gun; spaceInBackpack = SpaceInBackpack;
        }

        public void war()
        {
            Console.WriteLine($"Имя воина:{name}, кол-во здоровья:{health}, максимальное кол-во украденных ресурсов: {spaceInBackpack}, оружие: {gun}");
            Console.WriteLine("Имеет способность воровать ресурсы врага в огромных количествах");
            Console.WriteLine();
        }
    }

 }
