using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    class Menu
    {
        public static void Content()
        {     
            string choise = Console.ReadLine();
            if (choise == "0") { /*Worker.Program();*/ }
            else { Client.Program(); }
        }
    }
}
