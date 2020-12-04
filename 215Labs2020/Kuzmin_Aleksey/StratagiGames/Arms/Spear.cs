using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Arms
{
    class Spear : Skills, StratagiGames.IMove
    {
        public Spear()
        {
            _name = "Копьеносец";
            _hp = 8;
            _armor = 2;
            _damage = 5;
            _spead = 4;
            _vision = 4;
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
            Spear spear = new Spear();
        }
    }
}
