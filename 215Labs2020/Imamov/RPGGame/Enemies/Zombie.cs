using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.RPGGame.Enemies
{
    public class Zombie : Enemy
    {
        public Zombie(string _name, int _attack, int _health)
                : base(_name, _attack, _health)
        {
            numOfAttack = 3;
        }

        // Battle methods -------------------------------------------

        public void Tear(Forgotten target)
        {
            target.health -= attack + 5;
        }

        public void Bite(Forgotten target)
        {
            target.health -= attack + 2;
        }

        public void ZombieTurn(int choice, Forgotten target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Zombie punched you!");
            }

            if (choice == 2)
            {
                Tear(target);
                Console.WriteLine("Zombie tried to tear you!");
            }

            if (choice == 3)
            {
                Bite(target);
                Console.WriteLine("Zombie bitted you!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
