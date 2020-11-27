using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Cooperators
{
    class Medic : Skills, StratagiGames.IAttack, StratagiGames.IMoveForward, StratagiGames.IMoveBack
    {
        public Medic()
        {
            _name = "Санитар";
            _hp = 2;
            _armor = 0;
            _damage = 0;
            _spead = 4;
            _vision = 2;
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
            Medic medic = new Medic();
        }
    }
}
