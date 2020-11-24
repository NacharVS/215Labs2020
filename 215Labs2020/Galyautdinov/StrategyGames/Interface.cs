using System;

namespace _215Labs2020.Galyautdinov.StrategyGames
{
    interface IAttack
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"атаковал с уроном: {Damage} ед.");
        }
    }
    interface IMovable
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
    }
    interface IHeight
    {
        public int Damage { get; }
        public double height { get;}

        public void Height()
        {
            Console.WriteLine($"нанес урон {Damage} с высоты: {height} м.");
        }
    }
    interface IResource
    {
        public int Resource { get; }

        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }
    }
    interface IWork
    {
        public int Hours { get; }

        public void Work()
        {
            Console.WriteLine($"работает {Hours} часов.");
        }
    }
    interface IRadius
    {
        public double Radius { get; }

        public void Rad()
        {
            Console.WriteLine($"наблюдает в радиусе: {Radius} м.");
        }
    }
}
