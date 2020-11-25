using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.RPGGame.Hero
{
    abstract public class Person
    {
        public string name;
        public int attack;
        public int health;

        public Person(string _name, int _attack, int _health)
        {
            name = _name;
            attack = _attack;
            health = _health;
        }

        public void PrintStats()
        {
            Console.WriteLine($"{name} stats: ");
            Console.WriteLine("");
            Console.WriteLine($"Attack value is: {attack}");
            Console.WriteLine($"Health value is: {health}");
        }

        public void NormAttack(Person target)
        {
            target.health -= attack;
        }
    }
}
