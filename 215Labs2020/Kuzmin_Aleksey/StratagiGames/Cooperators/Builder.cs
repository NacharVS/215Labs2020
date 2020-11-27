using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Cooperators
{
    class Builder : Skills, StratagiGames.IAttack, StratagiGames.IMoveForward, StratagiGames.IMoveBack
    {
        public Builder()
        {
            _name = "Строитель";
            _hp = 4;
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
            Builder builder = new Builder();
        }
    }
}
