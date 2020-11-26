using System;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.RPGGame.Enemies
{
        public class Rat : Enemy
        {
            public Rat(string _name, int _attack, int _health)
                : base(_name, _attack, _health)
            {
                numOfAttack = 2;
            }

            //  Battle methods ---------------------------------------------

            public void Bite(Forgotten target)
            {
                target.health -= attack + 2;
            }

            public void RatTurn(int choice, Forgotten target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Rat whacked you!");

                }

                if (choice == 2)
                {
                    Bite(target);
                    Console.WriteLine("Rat bite from you!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    
}
