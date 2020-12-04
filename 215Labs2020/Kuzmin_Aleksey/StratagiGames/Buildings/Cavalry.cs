using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Buildings
{
    class Cavalry : Skills, StratagiGames.IMove
    {
        public Cavalry()
        {
            _name = "Всадник";
            _hp = 8;
            _armor = 6;
            _damage = 6;
            _spead = 6;
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
            Cavalry cavalery = new Cavalry();
        }
    }
}
