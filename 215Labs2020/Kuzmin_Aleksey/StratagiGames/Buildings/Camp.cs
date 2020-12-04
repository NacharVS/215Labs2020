using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Buildings
{
    class Mine : Skills, StratagiGames.IMove
    {
        public Mine()
        {
            _name = "Шахта";
            _hp = 10;
            _armor = 0;
            _damage = 0;
            _spead = 0;
            _vision = 4;
            _residence = 8;
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
            Mine mine = new Mine();
        }
    }
}
