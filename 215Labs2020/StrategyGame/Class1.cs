using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Class1
    {

        public static void proverka()
        {
            IDamage Attak;
            ISpeed speed;


            knight a = new knight(12, 14, 14, 13);

            Attak = a;
            a.proverka();
            Console.WriteLine("************************");
            builder c = new builder(12, 13);
            speed = c;
            a.proverka2();
            //string we = Console.ReadLine();
            //if (we == "0") yes = 0;
            //int b = int.Parse(Console.ReadLine());
        }
        //public static void proverka2()
        //{
        //    ISpeed speed;


        //    builder a = new builder(12, 13);
        //    speed = a;
        //    a.proverka2();
        //}
    }
}
