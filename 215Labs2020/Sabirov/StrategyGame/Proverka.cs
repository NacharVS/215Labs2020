using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Proverka
    {
        

        public static void proverka()
        {
            IMoveUnit move;
            IAttack attack;
            IResourceGatWood GatherWood;
            IResourceGatGold GatherGold;
            IBuildingTime time;

            Archer arc = new Archer(3, 40, 10, 9, 2);
            move = arc;
            attack = arc;
            arc.Move();
            arc.Attack();

            Peasant pea = new Peasant(3, 30, 4, 10, 0);
            move = pea;
            attack = pea;
            GatherGold = pea;
            GatherWood = pea;
            pea.Attack();
            pea.Move();

            Barraks bar = new Barraks(1200, 20);
            time = bar;
            bar.Time();
            
        }
    }
}
