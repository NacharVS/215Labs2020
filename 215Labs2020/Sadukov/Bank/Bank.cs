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
        public string surname;
        public double money = 0;
        public double deposit = 0.061;
        public double salary = 0;
        public string profession;
        public int experience;
        public string Name => name;
        public int Day => day;
        public int Month => month;
        public int Age => age;
        public string Email => email;
        public double Money => money;
        public string Surname => surname;
        public double Salary => salary;
        public string Profession => profession;
        public int Experience => experience;

        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetSurname(string _surname)
        {
            surname = _surname;
        }
        public void SetEmail(string _email)
        {
            email = _email;
        }
        public void deposit1(double SUM)
        {
            if (SUM < money)
            {
                money = money - SUM;
                SUM = SUM * deposit;
                money = money + SUM;
            }
        
        }
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
        public void prof(string x)
        {
            if (x == "Manager")
            {
                salary = 2500;

            }
            else if (x == "Cashier")
            {
                salary = 2200;

            }
            else if (x == "Security")
            {
                salary = 2000;

            }
            else if (x == "Boss")
            {
                salary = 100000;

            }
            else if (x == "Janitor")
            {
                salary = 1500;

            }
        }



    }
}

        
    

