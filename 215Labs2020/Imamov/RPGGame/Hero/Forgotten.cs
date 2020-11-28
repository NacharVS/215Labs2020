using System;
using _215Labs2020.Imamov.RPGGame.Enemies;

namespace _215Labs2020.Imamov.RPGGame.Hero
{
    public class Forgotten : Person
    {
        public int healLvl = 7, maxHealth = 15;

        public Forgotten(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        public void LevelUp()
        {
            Console.WriteLine("You leveled up !");
            Console.WriteLine("Attack +3");
            Console.WriteLine("Max health +10");
            Console.WriteLine("Heal +5");
            Console.ReadLine();
            Console.Clear();

            attack += 3;
            maxHealth += 10;
            health = maxHealth;
            healLvl += 5;
        }

        // Special

        public void Heal()
        {
            health += healLvl;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void SpinAttack(Enemy target)
        {
            target.health -= ((attack - 2) * 3);
        }

        public void DoubleSlash(Enemy target)
        {
            target.health -= attack * 2;
        }

        // Methods used in Battle

        public int Choice() // Decisions
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Special");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Thats not one of the options! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3) // Specials menu
                {
                    Console.WriteLine("Choose Special:");
                    Console.WriteLine("1. Spin Attack");
                    Console.WriteLine("2. Double Slash");
                    Console.WriteLine("3. <--- Go back");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Thats not one of the options ! Try again!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }
        private const int _NormAttack = 1;
        private const int _Heal = 2;
        private const int _SpinAttack = 3;
        private const int _DoubleSlash = 4;
        public void YourTurn(int decision, Enemy target)
        {
            switch (decision)
            {
                case _NormAttack:
                    NormAttack(target);
                    Console.WriteLine("You kicked the enemy!");
                    break;
                case _Heal:
                    Heal();
                    Console.WriteLine($"You healed for {healLvl} health!");
                    break;
                case _SpinAttack:
                    SpinAttack(target);
                    Console.WriteLine("You used spin attack!");
                    break;
                case _DoubleSlash:
                    DoubleSlash(target);
                    Console.WriteLine("You used double slash!");
                    break;
            }
        }
    }
}
