using System;

namespace _215Labs2020.Galyautdinov.StrategyGames
{
    interface IAttack
    {
        public int Damage { get; }
        public void Attack()
        {
            Console.WriteLine($"Атака Воина с уроном: {Damage} ед.");
        }
    }
    interface IMovable
    {
        public double Speed { get; }
        public void Move()
        {
            Console.WriteLine($"Воин движется со скоростью: {Speed} км/ч");
        }
    }
    interface IHeight
    {
        public int Damage { get; }
        public double height { get;}

        public void Height()
        {
            Console.WriteLine($"Воин нанес урон {Damage} с высоты: {height} м.");
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
}
