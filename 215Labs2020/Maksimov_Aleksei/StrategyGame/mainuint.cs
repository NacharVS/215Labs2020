using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame
{
    abstract class mainuint
    {
        private string name;
        private int health;
        private int radius;
        private string gun;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
          
        }
        public string Gun
        {
            get
            {
                return gun;
            }
            set
            {
                gun = value;
            }
        }




    }
}























