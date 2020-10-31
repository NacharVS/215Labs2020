using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.BankKlas
{
    
        class rabotnikk : bank2
        {
            private static string fio11 = "Иванов Иван Иванович";
            private static int zarplata;
            private static int _id=288;
            public static string FIO
            {
                get
                {
                    return fio11;
                }
                set
                {
                    fio11 = value;
                }
            }
            public static int Zarplata
            {
                get
                {
                    return zarplata;
                }
                set
                {
                    zarplata = 9999000;
                }
            }
            public static int Id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = 228;
                }
            }
        }
    
}
