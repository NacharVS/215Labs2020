using System;
using _215Labs2020.Imamov.StrategyGame.EnemyNODUnites;
using _215Labs2020.Imamov.StrategyGame.FriendlyGDIUnites;
using _215Labs2020.Imamov.StrategyGame.Buildings;

namespace _215Labs2020.Imamov.StrategyGame
{
    class Checking
    {
        public static void Run()
        {
            IntAttack attack;
            IntUnitsMovement movement;
            IntRange range;
            IntCredits credits;

            GDISoldiers soldiers = new GDISoldiers("GDI Soldiers", 70, 15, 20, 25);
            movement = soldiers;
            attack = soldiers;
            soldiers.Movement();
            soldiers.Attack();

            GDISnipers snipers = new GDISnipers("GDI Snipers", 55, 25, 30, 35);
            movement = snipers;
            attack = snipers;
            snipers.Movement();
            snipers.Attack();

            GDIHeavyTank tank = new GDIHeavyTank("GDI Heavy Tank", 150, 35, 25, 20);
            movement = tank;
            attack = tank;
            tank.Attack();
            tank.Movement();

            GDIHarvestr harvestr = new GDIHarvestr("GDI Harvestr", 90, 10, 2, 25, 900);
            movement = harvestr;
            attack = harvestr;
            harvestr.Attack();
            harvestr.Movement();
            harvestr.PointsCredit();

            GDIHammer hammer = new GDIHammer("GDI Hammer", 80, 20, 25, 50);
            movement = hammer;
            attack = hammer;
            hammer.Attack();
            hammer.Movement();

            NODSoldiers soldiers1 = new NODSoldiers("NOD Soldiers", 70, 15, 15, 30);
            movement = soldiers1;
            attack = soldiers1;
            soldiers1.Attack();
            soldiers1.Movement();

            NODSnipers snipers1 = new NODSnipers("NOD Snipers", 50, 30, 30, 40);
            movement = snipers1;
            attack = snipers1;
            snipers1.Attack();
            snipers1.Movement();

            NODFlameTank flameTank = new NODFlameTank("NOD Flame Tank", 120, 40, 15, 25);
            movement = flameTank;
            attack = flameTank;
            flameTank.Attack();
            flameTank.Movement();

            NODBuggy buggy = new NODBuggy("NOD Buggy", 65, 25, 20, 60);
            movement = buggy;
            attack = buggy;
            buggy.Attack();
            buggy.Movement();

            NODHarvestr harvestr1 = new NODHarvestr("NOD Harvestr", 90, 10, 2, 25,700);
            movement = harvestr1;
            attack = harvestr1;
            harvestr1.Attack();
            harvestr1.Movement();
            harvestr1.PointsCredit();

            Airport airport = new Airport("Airport", 500, 50,400);
            credits = airport;
            range = airport;
            airport.PointsCredit();
            airport.BuildingViewRange();

            Labaratory labaratory = new Labaratory("Labaratory", 600, 60,800);
            credits = labaratory;
            range = labaratory;
            labaratory.PointsCredit();
            labaratory.BuildingViewRange();

            MachineFactory machinefactory = new MachineFactory("Machine factory", 700, 70,1000);
            credits = machinefactory;
            range = machinefactory;
            machinefactory.PointsCredit();
            machinefactory.BuildingViewRange();

            PowerStation powerStation = new PowerStation("Power Station", 800, 80,1500);
            credits = powerStation;
            range = powerStation;
            powerStation.PointsCredit();
            powerStation.BuildingViewRange();

            Quarters quarters = new Quarters("Quarters", 900, 90,800);
            credits = quarters;
            range = quarters;
            quarters.PointsCredit();
            quarters.BuildingViewRange();
        }
    }
}
