using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.RPGgames
{
    abstract class Skills
    {
        public string _name { get; set; }
        public int _hp { get; set; }
        public int _armor { get; set; }
        public int _damage { get; set; }
        public int _spead { get; set; }
        public int _vision { get; set; }
        public int _residence { get; set; }
    }
}
