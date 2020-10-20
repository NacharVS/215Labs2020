using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Bank
    {
        private int score;
        public int CreateAccount
        {
            get { return score; }
            set
            {
                Console.WriteLine("Введите свою фамилию, имя, отчество: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите дату своего рождения: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите сумму первого взноса: ");
                int donation = int.Parse(Console.ReadLine());
                if (donation <= 10000) { Console.WriteLine("Ошибка. Сумма взноса меньше 10 000р."); }
                score += donation;
            }            
        }
        public int Replenish
        {
            get { return score; }
            set
            {
                Console.WriteLine();
                score += int.Parse(Console.ReadLine());
            }
        }
    }

}
