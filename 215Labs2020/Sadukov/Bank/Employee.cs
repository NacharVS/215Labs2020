using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Employee : Bank
    {

        public Employee(string Name, string Surname, int Day, int Month, int Age, string Email, double Salary,string Profession)
        {
            name = Name;
            surname = Surname;
            day = Day;
            month = Month;
            age = Age;
            email = Email;
            salary = Salary;
            profession = Profession;
        }
        private static Dictionary<int, Employee> PersonInfo = new Dictionary<int, Employee>();

        private static void GetInfo()
        {

            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Имя: {item.Value.Name}, Фамилия: {item.Value.Surname}, День рождения: {item.Value.Day}, Месяц рождения: {item.Value.Age}, Год рождения: {item.Value.Age},E-mail:{item.Value.Email},Зп:{item.Value.Salary}, Профессия:{item.Value.Profession}");
            }

        }
        public static void Login()
        {
            
            PersonInfo.Add(1111, new Employee("Аяз", "сАДЫКОВ", 13, 12, 2003, "@", 100000 ,"Boss"));
            GetInfo();
            PersonInfo[1111].prof("Janitor");
            GetInfo();

        }
    }
}
