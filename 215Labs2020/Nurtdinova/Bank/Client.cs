using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova
{
    class Client : Person
    {
        public Client()
        {
            id = 2;
        }
        public void InputClient()
        {
            Console.WriteLine("Введите ваши данны (ФИО)");
            SNP = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            dateBorn = Convert.ToDateTime(Console.ReadLine());
        }
     
    }
}
