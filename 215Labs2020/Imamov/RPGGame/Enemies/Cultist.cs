using System;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.RPGGame.Enemies
{
        public class Cultist : Enemy
        {
            public Cultist(string _name, int _attack, int _health)
                : base(_name, _attack, _health)
            {
                numOfAttack = 3;
            }

            // Battle methods -------------------------------------------

            public void Slash(Forgotten target)
            {
                target.health -= attack + 5;
            }

            public void SheildSlam(Forgotten target)
            {
                target.health -= attack + 2;
            }

            public void CultistTurn(int choice, Forgotten target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Cultist punched you!");
                }

                if (choice == 2)
                {
                    Slash(target);
                    Console.WriteLine("Cultist slashed you!");
                }

                if (choice == 3)
                {
                    SheildSlam(target);
                    Console.WriteLine("Cultist slammed you with his shield!");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    
}

