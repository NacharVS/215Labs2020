

using System;


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

            
            Millitary ballista = new Millitary("Ballista",80, 110, 8, 5, 0);
            move = ballista;
            attack = ballista;
            ballista.Attack();
            ballista.Move();

            
            Millitary footman = new Millitary("Footman",6, 60, 1, 10, 2);
            move = footman;
            attack = footman;
            footman.Attack();


           Millitary GnomishSubmarine  = new Millitary("Gnomish Submarine",3, 40, 10, 9, 2);
            move = GnomishSubmarine;
            attack = GnomishSubmarine;
            GnomishSubmarine.Move();
            GnomishSubmarine.Attack();


            Millitary knight = new Millitary("Knight",3, 40, 10, 9, 2);
            move = knight;
            attack = knight;
            knight.Move();
            knight.Attack();


            Millitary archer = new Millitary("Archer",3, 40, 10, 9, 2);
            move = archer;
            attack = archer;
            archer.Move();
            archer.Attack();

            
            Neutral peasant = new Neutral("Peasant",3, 30, 4, 10, 0);
            move = peasant;
            attack = peasant;
            GatherGold = peasant;
            GatherWood = peasant;
            peasant.Attack();
            peasant.Move();
            peasant.ResG();
            peasant.ResW();

            Neutral peon = new Neutral("Peon", 3, 30, 4, 10, 0);
            move = peon;
            attack = peon;
            GatherGold = peon;
            GatherWood = peon;
            peon.Attack();
            peon.Move();
            peon.ResG();
            peon.ResW();


            Neutral PitLord = new Neutral("Pit Lord", 56, 300, 8, 30, 5);
            move = PitLord;
            attack = PitLord;
            PitLord.Attack();
            PitLord.Move();

            Neutral FireLord = new Neutral("Firelord", 42, 400, 55, 320, 8);
            move = FireLord;
            attack = FireLord;
            FireLord.Attack();
            FireLord.Move();

            Neutral Naga = new Neutral("Naga sea witch", 51, 429, 60, 270, 6);
            move = Naga;
            attack = Naga;
            Naga.Attack();
            Naga.Move();


            Building barracks = new Building("Barracks", 20, 1200, 15000, 2000, 700);
            time = barracks;
            product = barracks;
            barracks.Time();
            barracks.Production();


            Building farm = new Building("Farm",20,400,10000,1000,500);
            time = farm;
            product = farm;
            farm.Time();
            farm.Production();


            Building ScoutTower = new Building("Scout Tower",20,100,13000,1000,550);
            time = ScoutTower;
            product = ScoutTower;
            ScoutTower.Time();
            ScoutTower.Production();


            Building blm = new Building("Blacksmith",20,775,12000,2000,800);
            time = blm;
            product = blm;
            blm.Time();
            blm.Production();


            Building TownHall = new Building("Town Hall",20,800,17000,2500,700);
            time = TownHall;
            product = TownHall;
            TownHall.Time();
            TownHall.Production();
            Console.WriteLine(Unit._gold);
        }
    }
}
