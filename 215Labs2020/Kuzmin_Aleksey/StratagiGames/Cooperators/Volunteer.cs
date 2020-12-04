using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Cooperators
{
    class Volunteer : Skills, StratagiGames.IMove
    {
        public Volunteer()
        {
            _name = "Доброволец";
            _hp = 2;
            _armor = 0;
            _damage = 2;
            _spead = 4;
            _vision = 2;
            _residence = 1;
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
            Volunteer volunteer = new Volunteer();
        }
    }
}
