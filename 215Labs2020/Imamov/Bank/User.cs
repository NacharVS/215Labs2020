﻿using System;
using _215Labs2020.Imamov.BankAcc;

namespace _215Labs2020.Imamov.BankAcc
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
