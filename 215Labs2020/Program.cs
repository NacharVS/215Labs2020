using System;
using _215Labs2020.Safiullin;
using _215Labs2020.Safiullin.Delegates;
using _215Labs2020.Safiullin.Statistical_game.Actions;

namespace _215Labs2020
{
    class Program
    {
        static void Main (string[] args)
        {
            IAttack attack;
            IMovable move;
            int a = 1;
            if (a > 1)
            {
                attack = new Human();
                attack.Attack();
            }
            else
            {
                move = new Human();
                move.Move();
            }
        }
    }
}
