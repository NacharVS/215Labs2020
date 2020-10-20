using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class Bank
    {
        private int score;
        public static void CreateAccount()
        {
            Console.WriteLine("Введите Фамилию, Имя, Отчество:  ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:  ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Введите сумму первого депозита:  ");
            int deposit = int.Parse(Console.ReadLine());



        }





    }
}
