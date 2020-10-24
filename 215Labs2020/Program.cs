using System;
using _215Labs2020.Шагимуратова;

namespace _215Labs2020
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int c;
        //    int ii = 1;
        //    bank[] Users = new bank[ii];
        //    do
        //    {
        //        //bank[] Users = new bank[ii];
        //        for (int i = 0; i < ii; i++)
        //        {
        //            Users[i] = new bank();
        //            bank.Reg(Users[i]);
        //            Console.WriteLine($"{Users[i].Name} {Users[i].SurName} , у вас на счету {Users[i].summinvklad} ");
        //        }
        //        Console.WriteLine("Вы хотите зарегистрировать еще одного юзера? нажмите 1-да , 2 - нет");
        //        int choose = int.Parse(Console.ReadLine());
        //        if (choose == 1) c = 1; 
        //    } while (c==1);
           
        //}
        static void Main (string[] args)
        {
            OperatorsOverLoads c1 = new OperatorsOverLoads(2);
            OperatorsOverLoads c2 = new OperatorsOverLoads(8);
            double sum;
            sum = (c1+c2);
            Console.WriteLine(sum);
            

        }
    }

}
