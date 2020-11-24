using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace _215Labs2020.Imamov
{

    abstract class User
    {
        private static string name;
        private static string name2;
        public static string Name
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
        public static string Name2
        {
            get
            {
                return name2;
            }
            set
            {
                name2 = value;
            }
        }
    }
}
