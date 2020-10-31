using System;

namespace _215Labs2020.Nurtdinova
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Client client = new Client();
            Employee employee = new Employee();
            Console.WriteLine("Выберите пользователя(клиент или работник цифры  1 или 2)");
            int _id = Convert.ToInt32(Console.ReadLine());
            if (client.id==_id)
            {
                client.InputClient();
                bank.method();
            }else if (employee.id == _id)
            {
                employee.PrintEmployee();
            }
            Console.ReadKey();
        }
    }
}
