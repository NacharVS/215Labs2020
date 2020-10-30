using System;
using _215Labs2020.Galyautdinov;
using _215Labs2020.Galyautdinov.Bank_class;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bank bank = new Bank();
            Client client = new Client("Igor");
            Employee employee1 = new Employee("Timur");
            
            Console.WriteLine("1. Клиент");
            Console.WriteLine("2. Сотрудник");
            client._id = int.Parse(Console.ReadLine());
            if (client._id==1)
            {
                bank.Operation();
            }
            else if (client._id == 2)
            {
                Employee.employee();
            }
            else Console.WriteLine("...");
            Console.Read();
        }
    }
}
