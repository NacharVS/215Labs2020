using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    class Employee : Abstract
    {
        private Employee(double bill, string name, DateTime birthday, string telephone)
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _salary = 30000;
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        private static Dictionary<int, Employee> PersonInfo = new Dictionary<int, Employee>();      
        private static void GetInfo()
        {
            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Счет: {item.Value.Bill}, ФИО: {item.Value.Name}, Дата рождения: {item.Value.Birthday}, Возраст: {item.Value.Age}, Телефон: {item.Value.Telephone}, Зарплата: {item.Value.Salary}");
            }

        }
        public static void Program()
        {
            //Первый взнос, Имя, Дата рождения, телефон.
            PersonInfo.Add(1111, new Employee(100000, "Клиент1", new DateTime(2000, 2, 21), "8989829198"));
            PersonInfo.Add(1112, new Employee(500000, "Клиент5", new DateTime(2002, 12, 31), "213124323"));
            GetInfo();
            PersonInfo[1111].Refill(200000);
            GetInfo();
            GetInfo();
        }
    }
}
