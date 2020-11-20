using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова
{
    abstract class All_Unit
    {
        private int  _level;
        private int  _id;
        private int  _health;
        private int  _speed;
        private int  _damage;
        private int  _armor;

        public int Speed { get => _speed; set => _speed = value; }
        public int Level { get => _level; set => _level = value; }
        public int Id { get => _id; set => _id = value; }
        public int Health { get => _health; set => _health = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public int Armor { get => _armor; set => _armor = value; }
    }
}
