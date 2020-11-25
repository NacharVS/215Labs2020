using _215Labs2020.Sabirov.StrategyGame.Buildings;
using _215Labs2020.Sabirov.StrategyGame.Military;
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
            IProduction product;

            Ballista bal = new Ballista(80, 110, 8, 5, 0);
            move = bal;
            attack = bal;
            bal.Move();
            bal.Attack();

            Footman fot = new Footman(6, 60, 1, 10, 2);
            move = fot;
            attack = fot;
            fot.Move();
            fot.Attack();

            GnomishSubmarine gs  = new GnomishSubmarine(3, 40, 10, 9, 2);
            move = gs;
            attack = gs;
            gs.Move();
            gs.Attack();

            Knight kn = new Knight(3, 40, 10, 9, 2);
            move = kn;
            attack = kn;
            kn.Move();
            kn.Attack();

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

            TownHall bar = new TownHall(1200, 20);
            time = bar;
            product = bar;
            bar.Time();
            bar.Production();

            Farm far = new Farm(400, 20);
            time = far;
            product = far;
            far.Time();
            far.Production();

            ScoutTower sc = new ScoutTower(100, 20);
            time = sc;
            product = sc;
            sc.Time();
            sc.Production();

            Blacksmith blm = new Blacksmith(775, 20);
            time = blm;
            product = blm;
            blm.Time();
            blm.Production();

            Barracks barr = new Barracks(800, 20);
            time = barr;
            product = barr;
            barr.Time();
            barr.Production();
        }
    }
}
