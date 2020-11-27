using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Arms
{
     class Scout : Skills, StratagiGames.IAttack, StratagiGames.IMoveForward, StratagiGames.IMoveBack
    {
        public Scout()
        {
            _name = "Разведчик";
            _hp = 5;
            _armor = 2;
            _damage = 2;
            _spead = 8;
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
            Scout scout = new Scout();            
        }
    }
}
