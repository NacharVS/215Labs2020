

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



            int yes = 1;
            while (yes == 1)
            {
                Console.WriteLine("What do you want to do(build a building(1)\nhire a squad(2)\nhire neutral creatures(3)\nhire peaceful creatures(4)\nFind out how much gold you have(5))");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {

                    case (2):
                        Console.WriteLine("who exactly(Ballista(1)\nFootman(2)\nGnomish Submarine(3)\nKnight(4)\nArcher(5))");
                        int b = int.Parse(Console.ReadLine());

                        switch (b)
                        {
                            case (1):
                                Millitary ballista = new Millitary("Ballista", 80, 110, 8, 5, 0);
                                move = ballista;
                                attack = ballista;
                                ballista.Attack();
                                ballista.Move();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                string cont2 = Console.ReadLine();
                                if (cont2 == "n") yes = 0;
                                break;


                            case (2):
                                Millitary footman = new Millitary("Footman", 6, 60, 1, 10, 2);
                                move = footman;
                                attack = footman;
                                footman.Attack();
                                footman.Move();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont2 = Console.ReadLine();
                                if (cont2 == "n") yes = 0;
                                break;

                            case (3):
                                Millitary GnomishSubmarine = new Millitary("Gnomish Submarine", 3, 40, 10, 9, 2);
                                move = GnomishSubmarine;
                                attack = GnomishSubmarine;
                                GnomishSubmarine.Move();
                                GnomishSubmarine.Attack();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont2 = Console.ReadLine();
                                if (cont2 == "n") yes = 0;
                                break;
                            case (4):
                                Millitary knight = new Millitary("Knight", 3, 40, 10, 9, 2);
                                move = knight;
                                attack = knight;
                                knight.Move();
                                knight.Attack();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont2 = Console.ReadLine();
                                if (cont2 == "n") yes = 0;
                                break;

                            case (5):
                                Millitary archer = new Millitary("Archer", 3, 40, 10, 9, 2);
                                move = archer;
                                attack = archer;
                                archer.Move();
                                archer.Attack();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont2 = Console.ReadLine();
                                if (cont2 == "n") yes = 0;
                                break;
                        }
                        break;


                    case (4):
                        Console.WriteLine("who exactly(Peasant(1)\nPeon(2))");
                        int c = int.Parse(Console.ReadLine());
                        switch (c)
                        {

                            case (1):
                                Neutral peasant = new Neutral("Peasant", 3, 30, 4, 10, 0);
                                move = peasant;
                                attack = peasant;
                                GatherGold = peasant;
                                GatherWood = peasant;
                                peasant.Attack();
                                peasant.Move();
                                peasant.ResG();
                                peasant.ResW();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                string cont3 = Console.ReadLine();
                                if (cont3 == "n") yes = 0;
                                break;
                            case (2):
                                Neutral peon = new Neutral("Peon", 3, 30, 4, 10, 0);
                                move = peon;
                                attack = peon;
                                GatherGold = peon;
                                GatherWood = peon;
                                peon.Attack();
                                peon.Move();
                                peon.ResG();
                                peon.ResW();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont3 = Console.ReadLine();
                                if (cont3 == "n") yes = 0;
                                break;
                        }
                        break;


                    case (3):
                        Console.WriteLine("who exactly(Pitlord(1)\nFirelord(2)\nNaga sea witch(3))");
                        int d = int.Parse(Console.ReadLine());
                        switch (d)
                        {
                            case (1):
                                Neutral PitLord = new Neutral("Pit Lord", 56, 300, 8, 30, 5);
                                move = PitLord;
                                attack = PitLord;
                                PitLord.Attack();
                                PitLord.Move();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                string cont4 = Console.ReadLine();
                                if (cont4 == "n") yes = 0;
                                break;

                            case (2):

                                Neutral FireLord = new Neutral("Firelord", 42, 400, 55, 320, 8);
                                move = FireLord;
                                attack = FireLord;
                                FireLord.Attack();
                                FireLord.Move();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont4 = Console.ReadLine();
                                if (cont4 == "n") yes = 0;
                                break;

                            case (3):
                                Neutral Naga = new Neutral("Naga sea witch", 51, 429, 60, 270, 6);
                                move = Naga;
                                attack = Naga;
                                Naga.Attack();
                                Naga.Move();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont4 = Console.ReadLine();
                                if (cont4 == "n") yes = 0;
                                break;
                        }
                        break;

                    case (1):

                        Console.WriteLine("What exactly(Barracks(1)\nFarm(2)\nScout Tower(3)\nBlacksmith(4)\nTown Hall(5))");
                        int e = int.Parse(Console.ReadLine());
                        switch (e)
                        {
                            case (1):
                                Building barracks = new Building("Barracks", 20, 1200, 15000, 2000, 700);
                                time = barracks;
                                product = barracks;
                                barracks.Time();
                                barracks.Production();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                string cont1 = Console.ReadLine();
                                if (cont1 == "n") yes = 0;
                                break;
                            case (2):
                                Building farm = new Building("Farm", 20, 400, 10000, 1000, 500);
                                time = farm;
                                product = farm;
                                farm.Time();
                                farm.Production();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont1 = Console.ReadLine();
                                if (cont1 == "n") yes = 0;
                                break;
                            case (3):
                                Building ScoutTower = new Building("Scout Tower", 20, 100, 13000, 1000, 550);
                                time = ScoutTower;
                                product = ScoutTower;
                                ScoutTower.Time();
                                ScoutTower.Production();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont1 = Console.ReadLine();
                                if (cont1 == "n") yes = 0;
                                break;
                            case (4):
                                Building blm = new Building("Blacksmith", 20, 775, 12000, 2000, 800);
                                time = blm;
                                product = blm;
                                blm.Time();
                                blm.Production();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont1 = Console.ReadLine();
                                if (cont1 == "n") yes = 0;
                                break;
                            case (5):
                                Building TownHall = new Building("Town Hall", 20, 800, 17000, 2500, 700);
                                time = TownHall;
                                product = TownHall;
                                TownHall.Time();
                                TownHall.Production();
                                Console.WriteLine("Do you want to continue?\n y/n");
                                cont1 = Console.ReadLine();
                                if (cont1 == "n") yes = 0;
                                break;
                        }

                        break;
                    case (5):
                        Console.WriteLine($"Gold: {Unit._gold}");
                        Console.WriteLine("Do you want to continue?\n y/n");
                        string cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                }
            }
        }
    }
}
