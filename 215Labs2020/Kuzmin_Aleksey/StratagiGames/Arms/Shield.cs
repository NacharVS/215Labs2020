using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Arms
{
    class Shield : Skills, StratagiGames.IAttack, StratagiGames.IMoveForward, StratagiGames.IMoveBack
    {
        public Shield()
        {
            _name = "Щитонесец";
            _hp = 8;
            _armor = 6;
            _damage = 1;
            _spead = 2;
            _vision = 2;
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
            Shield shield = new Shield();
        }
    }
}
