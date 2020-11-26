using System;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.RPGGame.Enemies
{
        public class Dragon : Enemy
        {
            public int armor;

            public Dragon(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health)
            {
                numOfAttack = 4;
                armor = _armor;
            }

            // Battle methods ------------------------------------------------------------

            public void FireBreath(Forgotten target)
            {
                target.health -= attack * 2;
            }

            public void Claw(Forgotten target)
            {
                target.health -= attack + 3;
            }

            public void Bite(Forgotten target)
            {
                target.health -= attack + 4;
            }

            public void DragonTurn(int choice, Forgotten target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Dragon sneezed on you!");
                }

                if (choice == 2)
                {
                    FireBreath(target);
                    Console.WriteLine("Dragon used flamethrower on you!");
                }

                if (choice == 3)
                {
                    Claw(target);
                    Console.WriteLine("Dragon clawed you!");
                }

                if (choice == 4)
                {
                    Bite(target);
                    Console.WriteLine("Dragon bite you!");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    
}
