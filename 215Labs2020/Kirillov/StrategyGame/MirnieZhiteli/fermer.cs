using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame.MirnieZhiteli
{
    class fermer : mainuint, Imzh
    {
        public static string remeslo;
        public static int timeOfWork;
        public fermer(string Name, int Health, int TimeOfWork, string Remeslo)
        {
            name = Name; health = Health; remeslo = Remeslo; timeOfWork = TimeOfWork;
        }

        public void Mzh()
        {
            Console.WriteLine($"Имя фермера: {name}, кол-во здоровья: {health}, направление: {remeslo}, время работы: {timeOfWork} в день.");
            Console.WriteLine("Фермер заниается выращиванием культур.");
            Console.WriteLine();
        }
    }
}
