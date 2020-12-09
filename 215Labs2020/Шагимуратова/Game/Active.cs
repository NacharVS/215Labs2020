using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Game
{
    class Active
    {
        interface Movable
        {
            void movable()
            {
                Console.WriteLine($"Скорость передвижения:  км/ч.");
            }
        }
        interface Protect
        {
            void protect();
            
        }
        interface Attack
        {
            void attack()
            {
                Console.WriteLine($"Атака Воина с уроном:  ед.");
            }
        }
       

    }
}
