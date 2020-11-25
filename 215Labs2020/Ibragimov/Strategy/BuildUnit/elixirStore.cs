using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class ElixirStore : AbsarctClassVse
    {
        public int Elixir { get; private set; }


        public ElixirStore (int xp, int elixir)
        {

            XP = xp;

            Elixir = elixir;

        }
    }
}
