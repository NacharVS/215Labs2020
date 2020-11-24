using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.NPCs
{
    class HeroBountyHanter : XpGain, AIAttack, AIMovement
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public HeroBountyHanter (string name,int xp,double speed,int damage)
        {
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
    }
}
