using System;
using System.Collections;

namespace _215Labs2020.Sadukov
{
    abstract class Bank
    {

        public string name;
        public int day;
        public int month;
        public int age;
        public string email;
        public int id;
        public string surname;
        public double money = 0;
        public double deposit = 0.061;
        public string Name => name;
        public int Day => day;
        public int Month => month;
        public int Age => age;
        public string Email => email;
        public double Money => money;
        public string Surname => surname;


        public void put(double SUM)
        {
            if (SUM >= 10000 && SUM <= 200000)
            {
                money += SUM;
            }
        }
        public void withdraw(double SUM)
        {
            if (money >= SUM)
            {
                money -= SUM;
            }
        }
        public void CashBack(double SUM)
        {
            if (money >= SUM)
            {
                money -= SUM;
                money += SUM * 0.1;
            }
        }




    }
}

        
    

