using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Buildings
{
    class Catapult : Skills, StratagiGames.IMove
    {
        public Catapult()
        {
            _name = "Катапульта";
            _hp = 6;
            _armor = 0;
            _damage = 6;
            _spead = 2;
            _vision = 8;
            _residence = 0;
        }
        public int attack
        {
            get { return _hp; }
            set { _hp -= value; }
        }
        public int moveF
        {
            get { return _residence; }
            set { _residence += value; }
        }
        public int moveB
        {
            get { return _residence; }
            set { _residence -= value; }
        }
        public static void Program()
        {
            Catapult catapult = new Catapult();
        }
    }
}
