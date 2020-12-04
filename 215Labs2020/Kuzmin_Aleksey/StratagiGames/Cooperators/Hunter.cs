using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Cooperators
{
    class Hunter : Skills, StratagiGames.IMove
    {
        public Hunter()
        {
            _name = "Охотник";
            _hp = 6;
            _armor = 0;
            _damage = 4;
            _spead = 4;
            _vision = 4;
            _residence = 2;
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
            Hunter hunter = new Hunter();
        }
    }
}
