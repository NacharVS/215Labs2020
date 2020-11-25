using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.MirnieZhiteli
{
    class fermer : mainuint
    {
        public static string remeslo;
        public static int timeOfWork;
        public fermer(string Name, int Health, int TimeOfWork, string Remeslo)
        {
            name = Name; health = Health; remeslo = Remeslo; timeOfWork = TimeOfWork;
        }

        public static void fer()
        {
            Console.WriteLine($"Имя воина:{name}, кол-во здоровья:{health}, направление: {remeslo}, время работы: {timeOfWork} в день.");
            Console.WriteLine("Фермер заниается выращиванием культур.");
            Console.WriteLine();
        }
    }
}
