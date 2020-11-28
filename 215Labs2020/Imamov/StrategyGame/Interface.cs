using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame
{
    interface IntAttack
    {
        void Attack();
    }
    interface IntUnitsMovement
    {
        void Movement();
    }
    interface IntCredits
    {
       public void PointsCredit();
    }
    interface IntRange
    {
        void BuildingViewRange();
    }
}
