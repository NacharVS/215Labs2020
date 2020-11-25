using System;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.RPGGame.Enemies
{
    public class Enemy : Person
    {
        public int numOfAttack;

        public Enemy(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        // Battle methods

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }
}
        
