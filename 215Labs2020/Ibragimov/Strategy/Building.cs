using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy
{
    
        abstract class Building
        {
            private static int _health;
            private static int armour;
            private static int room;

            public static int Armour { get => armour; set => armour = value; }
            public static int Health { get => _health; set => _health = value; }
            public static int Room
            {
                get
                {
                    return room;
                }
                set
                {
                    if (room > 10)
                    {
                        Console.WriteLine("there is no room in this builidng");
                    }
                    else room = value;
                }
            }
        }
    
}
