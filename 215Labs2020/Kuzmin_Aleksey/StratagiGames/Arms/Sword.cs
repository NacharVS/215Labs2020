using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Arms
{
    class Sword : Skills, StratagiGames.IMove
    {
        public Sword()
        {
            _name = "Мечник";
            _hp = 8;
            _armor = 4;
            _damage = 6;
            _spead = 5;
            _vision = 0;
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
            Sword sword = new Sword();
        }
    }
}
