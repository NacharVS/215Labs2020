using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.StratagiGames
{
    interface IAttack
    {        
        public int attack { get; set; }        
    }
    interface IMoveForward
    {
        public int moveF { get; set; }
    }
    interface IMoveBack
    {
        public int moveB { get; set; }
    }
}
