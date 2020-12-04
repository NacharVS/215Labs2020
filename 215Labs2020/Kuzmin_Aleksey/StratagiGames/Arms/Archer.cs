using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames.Arms
{
    class Archer : Skills, StratagiGames.IMove
    {
        public Archer()
        {
            _name = "Лучник";
            _hp = 5;
            _armor = 0;
            _damage = 4;
            _spead = 5;
            _vision = 5;
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
            Archer archer = new Archer();
            Console.WriteLine(archer._name);
            Console.WriteLine(archer._hp);
            archer.attack = 5;
            Console.WriteLine(archer._hp);
            Console.WriteLine(archer._residence);
            archer.moveF = 2;
            archer.moveF = 2;
            archer.moveB = 3;
            Console.WriteLine(archer._residence);
        }       
    }    
}
