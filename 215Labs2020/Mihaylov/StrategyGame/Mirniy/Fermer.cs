using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Mirniy
{
    class Fermer : absract, Movement, Productivity
    {
        public int Speed { get; private set; }
        public int Gold { get; private set; }
        public Fermer(string name, int xp, int speed, int gold)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Gold = gold;
        }
        public void Movemen()
        {
            Console.WriteLine($"Скорость: {Speed} км/ч");
        }
        public void product()
        {
            Console.WriteLine($"Производительность: {Gold} золота/ч");
        }

        
    }
}