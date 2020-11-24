using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class main
    {
        public static void RunStrategy()
        {
            ISpeed move;
            IAttack attack;
            IHeight height;
            IResource resource;
            IDalnost dalnost;

            var voin_gladiator = new Unit_voin_gladiator("Гладиатор", 100, 10, 5);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_gladiator.Name);
            Console.WriteLine($"XP: {Unit_voin_gladiator.Xp}");
            move = voin_gladiator;
            move.Move();
            attack = voin_gladiator;
            attack.Attack();
            Console.WriteLine();
            
            var voin_golem = new Unit_voin_golem("Голем", 150, 14, 8);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_golem.Name);
            Console.WriteLine($"XP: {Unit_voin_golem.Xp}");
            move = voin_golem;
            move.Move();
            attack = voin_golem;
            attack.Attack();
            Console.WriteLine();

            var voin_gigant = new Unit_voin_gigant("Гигант", 150, 13, 10);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_gigant.Name);
            Console.WriteLine($"XP: {Unit_voin_gigant.Xp}");
            move = voin_gigant;
            move.Move();
            attack = voin_gigant;
            attack.Attack();
            Console.WriteLine();

            var voin_luchnick = new Unit_voin_luchnick("Лучник", 80, 10, 9, 8);//имя, хр, скорость, урон, дальнность
            Console.WriteLine(Unit_voin_luchnick.Name);
            Console.WriteLine($"XP: {Unit_voin_luchnick.Xp}");
            move = voin_luchnick;
            move.Move();
            attack = voin_luchnick;
            attack.Attack();
            dalnost = voin_luchnick;
            dalnost.dalnost();

            Console.WriteLine();

            var voin_vsadnik = new Unit_voin_vsadnik("Всадник", 100, 10, 8);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_vsadnik.Name);
            Console.WriteLine($"XP: {Unit_voin_vsadnik.Xp}");
            move = voin_vsadnik;
            move.Move();
            attack = voin_vsadnik;
            attack.Attack();
            Console.WriteLine();

            var mir_Cook = new Unit_mir_Cook("Повар", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_Cook.Name);
            Console.WriteLine($"XP: {Unit_mir_Cook.Xp}");
            move = mir_Cook;
            move.Move();
            resource = mir_Cook;
            resource.Res();
            Console.WriteLine();

            var mir_fermer = new Unit_mir_fermer("Фермер", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_fermer.Name);
            Console.WriteLine($"XP: {Unit_mir_fermer.Xp}");
            move = mir_fermer;
            move.Move();
            resource = mir_fermer;
            resource.Res();
            Console.WriteLine();

            var mir_fisherman = new Unit_mir_fisherman("Рыболов", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_fisherman.Name);
            Console.WriteLine($"XP: {Unit_mir_fisherman.Xp}");
            move = mir_fisherman;
            move.Move();
            resource = mir_fisherman;
            resource.Res();
            Console.WriteLine();

            var mir_kuznec = new Unit_mir_kuznec("Кузнец", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_kuznec.Name);
            Console.WriteLine($"XP: {Unit_mir_kuznec.Xp}");
            move = mir_kuznec;
            move.Move();
            resource = mir_kuznec;
            resource.Res();
            Console.WriteLine();

            var mir_mechanik = new Unit_mir_Mechanik("Механик", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_Mechanik.Name);
            Console.WriteLine($"XP: {Unit_mir_Mechanik.Xp}");
            move = mir_mechanik;
            move.Move();
            resource = mir_mechanik;
            resource.Res();
            Console.WriteLine();
        }
    }
}
