using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    abstract class Characteristic
    {
        public int _hp { get; set; }
        public int _armor { get; set; }
        public int _damage { get; set; }
        public int _spead { get; set; }
        public int _vision { get; set; }
        public abstract void GetInfo();
        
    }
    class Worker: Characteristic
    {
        public Worker()
        {
            _hp = 5;
            _armor = 0;
            _damage = 1;
            _spead = 10;
            _vision = 5;            
        }
        public override void GetInfo()
        {
            Console.WriteLine(_hp);
        }
    }

}
