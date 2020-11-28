using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Statistical_game.Actions
{
    interface IAttack 
    {
        public void Attack();
        
         /*Атака. Урон: {_damage} ед.*/
        
    }
    interface IMovable
    {
        public void Move();
        
        /*Двигается со скоростью : {_speed} км/ч*/
        
    }
    interface IResources
    {
        public void Resources();
        //ресурсы
    }
    interface IDalnost
    {
        public void Dalnost();
    }
}
