using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Praktika
    {
        public string name;
        private int raiting;
        public int Raiting
        {
            get
            { return raiting; }  
            set
            {if(value > 5)
                { raiting = 5; }
            else if(value < 2)
                { raiting = 2; }
            else { raiting = value;}
            }
            

        }

    }
}
