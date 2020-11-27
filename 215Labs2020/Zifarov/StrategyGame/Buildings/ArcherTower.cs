using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Buildings
{
    class ArcherTower : Units ,ISecurity 
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
            Console.WriteLine("Враг был замечен на горизонте");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine($"Башня лучниц нанесла урон по противнику {ArcherTower.Damage}");
        }
    }
}
