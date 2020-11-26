using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class main
    {
        public static void RunStrategy()
        {
            ISpeed v;
            IAttack attack;
            IHeight height;
            IResource resource;
            IDalnost dalnost;
            
            //ВОИНЫ
            var voin_gladiator = new Unit_voin_gladiator("Гладиатор", 100, 10, 5);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_gladiator.Name);
            Console.WriteLine($"XP: {Unit_voin_gladiator.Xp}");
            v = voin_gladiator;
            v.scorost();
            attack = voin_gladiator;
            attack.Attack();
            Console.WriteLine();
            
            var voin_golem = new Unit_voin_golem("Голем", 150, 14, 8);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_golem.Name);
            Console.WriteLine($"XP: {Unit_voin_golem.Xp}");
            v = voin_golem;
            v.scorost();
            attack = voin_golem;
            attack.Attack();
            Console.WriteLine();

            var voin_gigant = new Unit_voin_gigant("Гигант", 150, 13, 10);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_gigant.Name);
            Console.WriteLine($"XP: {Unit_voin_gigant.Xp}");
            v = voin_gigant;
            v.scorost();
            attack = voin_gigant;
            attack.Attack();
            Console.WriteLine();

            var voin_luchnick = new Unit_voin_luchnick("Лучник", 80, 10, 9, 8);//имя, хр, скорость, урон, дальнность
            Console.WriteLine(Unit_voin_luchnick.Name);
            Console.WriteLine($"XP: {Unit_voin_luchnick.Xp}");
            v = voin_luchnick;
            v.scorost();
            dalnost = voin_luchnick;
            dalnost.dalnost();

            Console.WriteLine();

            var voin_vsadnik = new Unit_voin_vsadnik("Всадник", 100, 10, 8);//имя, хр, скорость, урон
            Console.WriteLine(Unit_voin_vsadnik.Name);
            Console.WriteLine($"XP: {Unit_voin_vsadnik.Xp}");
            v = voin_vsadnik;
            v.scorost();
            attack = voin_vsadnik;
            attack.Attack();
            Console.WriteLine();

            //МИРНЫЕ ЖИТЕЛИ
            var mir_Cook = new Unit_mir_Cook("Повар", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_Cook.Name);
            Console.WriteLine($"XP: {Unit_mir_Cook.Xp}");
            v = mir_Cook;
            v.scorost();
            resource = mir_Cook;
            resource.Res();
            Console.WriteLine();

            var mir_fermer = new Unit_mir_fermer("Фермер", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_fermer.Name);
            Console.WriteLine($"XP: {Unit_mir_fermer.Xp}");
            v = mir_fermer;
            v.scorost();
            resource = mir_fermer;
            resource.Res();
            Console.WriteLine();

            var mir_fisherman = new Unit_mir_fisherman("Рыболов", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_fisherman.Name);
            Console.WriteLine($"XP: {Unit_mir_fisherman.Xp}");
            v = mir_fisherman;
            v.scorost();
            resource = mir_fisherman;
            resource.Res();
            Console.WriteLine();

            var mir_kuznec = new Unit_mir_kuznec("Кузнец", 90, 4, 20);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_kuznec.Name);
            Console.WriteLine($"XP: {Unit_mir_kuznec.Xp}");
            v = mir_kuznec;
            v.scorost();
            resource = mir_kuznec;
            resource.Res();
            Console.WriteLine();

            var mir_mechanik = new Unit_mir_Mechanik("Механик", 90, 4);//имя, хр, скорость, ресурс
            Console.WriteLine(Unit_mir_Mechanik.Name);
            Console.WriteLine($"XP: {Unit_mir_Mechanik.Xp}");
            v = mir_mechanik;
            v.scorost();
            Console.WriteLine();

            //БАШНИ
            var basa_Dirizhable = new Unit_basa_Dirizhable("Дирижабль", 90, 10, 20, 10);//имя, хр, скорость, высота, дальность
            Console.WriteLine(Unit_basa_Dirizhable.Name);
            Console.WriteLine($"XP: {Unit_basa_Dirizhable.Xp}");
            v = basa_Dirizhable;
            v.scorost();
            height = basa_Dirizhable;
            height.Height();
            dalnost = basa_Dirizhable;
            dalnost.dalnost();
            Console.WriteLine();

            var basa_Kazarma = new Unit_basa_Kazarma("Казарма", 90, 8);//имя, хр, дальность
            Console.WriteLine(Unit_basa_Kazarma.Name);
            Console.WriteLine($"XP: {Unit_basa_Kazarma.Xp}");
            dalnost = basa_Kazarma;
            dalnost.dalnost();
            Console.WriteLine();

            var basa_Krepost = new Unit_basa_Krepost("Крепость", 90, 10);//имя, хр, дальность
            Console.WriteLine(Unit_basa_Krepost.Name);
            Console.WriteLine($"XP: {Unit_basa_Krepost.Xp}");
            dalnost = basa_Krepost;
            dalnost.dalnost();
            Console.WriteLine();

            var basa_Kusnitsa = new Unit_basa_Kusnitsa("Кузница", 90, 14);//имя, хр, дальность
            Console.WriteLine(Unit_basa_Kusnitsa.Name);
            Console.WriteLine($"XP: {Unit_basa_Kusnitsa.Xp}");
            dalnost = basa_Kusnitsa;
            dalnost.dalnost();
            Console.WriteLine();

            var basa_shtab = new Unit_basa_shtab("Штаб", 90, 8);//имя, хр, дальность
            Console.WriteLine(Unit_basa_shtab.Name);
            Console.WriteLine($"XP: {Unit_basa_shtab.Xp}");
            dalnost = basa_shtab;
            dalnost.dalnost();
            Console.WriteLine();
        }
    }
}
