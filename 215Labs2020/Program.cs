﻿using System;
using _215Labs2020.Garaev.Bank;
using _215Labs2020.Garaev.Delegates;
using _215Labs2020.Garaev;
using _215Labs2020.Garaev.Strategy_games;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankPerson.Bank_deysviya();
            //Satellites.MongoReplaceSatellites("Starlink", new Satellites() { Age = 0.000000003, Name = "Starlink", Artificiality = true}).GetAwaiter().GetResult();
            //Satellites.MongoReplaceSatellites("Луна", new Satellites() { Age = 4.51, Name = "Луна" }).GetAwaiter().GetResult();
            Comets.MongoDeleteKomets("").GetAwaiter().GetResult();
            //Comets.Main3();
            //ObservableCollection.Main1();
            //Tasks.Task();
            //Asyncsum.mainMethod();
            //Console.ReadKey();
        }
    }
}
