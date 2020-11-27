using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class ElixirStore : AbsarctClassVse, IZdanie
    {
        public int Elixir { get; private set; }


        public ElixirStore (int xp, int elixir)
        {

            XP = xp;

            Elixir = elixir;

        }
        public void Zdanie1()
        {
            Console.WriteLine($"имеет хп {XP} и хранит {Elixir} ");


        }
    }
}
