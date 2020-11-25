using System;
using _215Labs2020.Nurtdinova.StrategyGame.Warrior;
using  _215Labs2020.Nurtdinova.StrategyGame;
namespace _215Labs2020.Nurtdinova
{
    class Program
    {
        static void Main(string[] args)
        {
            IAttack attack;
            ISpeeed spee;


            attack = new WarriorBatrak( 30, 10, 5);
            attack.Att();


            attack = new WarriorZulin(10, 5);
            attack.Att();
            spee = new WarriorZulin(10, 5);
            spee.sp();
        }
    }
}
