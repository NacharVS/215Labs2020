﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game.civilians
{
    class Kid : mainunit, Imzh
    {
        {
            public static string color;
            public static int age;
            public Kid(string Name, int Health, int Age, string Color)
            {
                name = Name; health = Health; age = Age; color = Color;
            }

            public void Mzh()
            {
                Console.WriteLine($"Имя: {name}, кол-во здоровья: {health}, возраст: {age}, цвет: {color}");
                Console.WriteLine("Имеет способность переносить огромные повреждения.");
                Console.WriteLine();
            }
        }
    }
}
}
