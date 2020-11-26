using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Buildings
{
    abstract class Cannon : Skills
    {
        public Cannon()
        {
            _hp = 0;
            _armor = 0;
            _damage = 0;
            _spead = 0;
            _vision = 0;
            _benefit = 0;
        }
    }
}
