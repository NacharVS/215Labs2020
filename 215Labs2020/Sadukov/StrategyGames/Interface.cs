using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov.StrategyGames
{
    interface IAttack
    {
        void Attack();
    }
    interface IMoveUnit
    {
        void Move();
    }

    interface IResourceGatWood
    {
        public void ResW();
    }
    interface IResourceGatGold
    {
        public void ResG();
    }
    interface IBuildingTime
    {
        public void Time();
    }
    interface IProduction
    {
        public void Production();
    }
}
