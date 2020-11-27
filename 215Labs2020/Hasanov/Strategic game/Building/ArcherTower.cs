using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class ArcherTower : Units, ISecurity
    {
        public ArcherTower(int health, int damage)
        {
            ArcherTower.Health = health;
            ArcherTower.Damage = damage;
        }
        public void Security()
        {
            Console.WriteLine("Башня лучникак построена ");
            System.Threading.Thread.Sleep(10000);
            if(Units.respect == _maxrespect)
            Console.WriteLine($"Башня лучниц нанесла урон по противнику {ArcherTower.Damage +10}");
            if (Units.rspect == _minrespect) Console.WriteLine($"Башня лучниц нанесла урон по противнику {ArcherTower.Damage - 10}");
            else Console.WriteLine($"Башня лучниц нанесла урон по противнику {ArcherTower.Damage }");
        }
    }
}
