using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    class Client : Abstract
    {        
        private Client(double bill, string name, DateTime birthday, string telephone) 
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;         
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        private static Dictionary<int, Client> PersonInfo = new Dictionary<int, Client>();       
        private static void GetInfo()
        {
            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Счет: {item.Value.Bill}, ФИО: {item.Value.Name}, Дата рождения: {item.Value.Birthday}, Возраст: {item.Value.Age}, Телефон: {item.Value.Telephone}");
            }            
        }
        public static void Program()
        {               
            //Первый взнос, Имя, Дата рождения, телефон.
            PersonInfo.Add(1111, new Client(100000, "Егор", new DateTime(2000, 2, 21), "8989829198"));            
            GetInfo();
            PersonInfo[1111].Refill(100000);
            PersonInfo[1111].SetName("Иван");
            GetInfo();
            GetInfo();
        }
    }
}
