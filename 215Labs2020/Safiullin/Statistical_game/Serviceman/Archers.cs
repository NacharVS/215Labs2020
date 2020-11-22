using _215Labs2020.Safiullin.Statistical_game.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Statistical_game.Serviceman
{
    class Archers : IMovable, IAttack
    {
        private double _speed;

        public double Speed
        {
            get => _speed;
            set => _speed = value * 0.1;
        }
         public void Attack()
        {
            Console.WriteLine("Лучник Атакуй! ");
        }
        public void Move()
        {
            Console.WriteLine("По пути");
            Console.WriteLine($"Лучник двигается со скоростью {_speed}  км/ч ");
        }    
        public void Think()
        {
            return;
        }
    }
}
