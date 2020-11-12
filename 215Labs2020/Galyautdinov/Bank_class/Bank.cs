using _215Labs2020.Galyautdinov.Bank_class;
using System;

namespace _215Labs2020.Galyautdinov
{
    class Bank
    {
        private static double bank_balans = 0;
        private static double percent = 0.061;
        private static long phone;
        private static int day_birthday;
        private static int month_birthday;
        private static int year_birthday;

        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;

        public Bank(double sum)
        {
            bank_balans = sum;
        }
        public void Put(double sum)
        {
            bank_balans += sum;
            Notify?.Invoke($"На счет поступило: {sum}");

        }
        public void Take(double sum)
        {
            if (bank_balans >= sum)
            {
                bank_balans -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");
            }
        }
        public void Transfer1(double sum)
        {
            if (bank_balans >= sum)
            {
                bank_balans -= sum;
                Notify?.Invoke($"Осуществлен перевод на  {sum} рублей.");
            }
        }
        public void Dep1(double sum)
        {
            bank_balans += sum;
            Notify?.Invoke($"На счет поступило: {sum}");

        }
        public static double Sum { get; private set; }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void FullName()
        {
            Console.WriteLine($"Сегодняшнее число: {DateTime.Now}");
            Console.WriteLine(Client.Name);
            try
            {
                Console.Write("Введите ваш номер телефона: ");
                phone = long.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Введите правильный номер телефона: ");
                phone = long.Parse(Console.ReadLine());
            }
            if (phone/10000000000==0 || phone/ 1000000000 != 8)
            {
                while (phone / 10000000000 == 0 || phone / 10000000000 != 8)
                {
                    Console.Write("Введиет правильный номер телефона: ");
                    phone = long.Parse(Console.ReadLine());
                }
            }
        }
        private static void Refill(double bank_balans)
        {
            Bank bank = new Bank(bank_balans);
            bank.Notify += DisplayMessage;

            int a=0;
            Console.Write("Введите сумму пополнения: ");
            int prov2 = 0;
            while (prov2 == 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    prov2++;
                }
                catch
                {
                    Console.WriteLine("Введиет правильную сумму");
                    
                    prov2 = 0;
                }
            }
            if (a < 10000)
            {
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                    Console.Write("Введите сумму пополнения: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            while (a > 200000)
            {
                Console.WriteLine("Максимальная сумма пополнения 200 000 рублей");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введиет правильную сумму");
                    a = int.Parse(Console.ReadLine());
                }
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                    Console.Write("Введите сумму пополнения: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            bank.Put(a);
        }
        private static void Withdrawal()
        {
            Bank bank = new Bank(bank_balans);
            bank.Notify += DisplayMessage;
            int a;
            Console.Write("Введите сумму которую хотите снять: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введиет правильную сумму");
                a = int.Parse(Console.ReadLine());
            }
            while (bank_balans - a < 0)
            {
                if (a < 10000)
                {
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма для снятия 10 000 рублей.");
                        Console.Write("Введите сумму которую хотите снять: ");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введиет правильную сумму");
                            a = int.Parse(Console.ReadLine());
                        }
                    }
                }
                while (a > 200000)
                {
                    Console.WriteLine("Максимальная сумма для снятия 200 000 рублей");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма для снятия 10 000 рублей.");
                        Console.Write("Введите сумму которую хотите снять: ");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введиет правильную сумму");
                            a = int.Parse(Console.ReadLine());
                        }
                    }
                }
                if (bank_balans - a < 0)
                {
                    Console.WriteLine($"Недостаточно средст для вывода. Ваш баланс {bank_balans}");
                    Console.Write("Введите сумму которую хотите снять: ");
                    try
                    {
                            a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            bank.Take(a);
        }
        private static void Transfer()
        {
            Bank bank = new Bank(bank_balans);
            bank.Notify += DisplayMessage;
            int a;
            Console.Write("Введите счет, на которую переводите деньги: ");
            int login_transfer = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму которую хотите перевести: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введиет правильную сумму");
                a = int.Parse(Console.ReadLine());
            }
            if (a < 10000)
            {
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            while (a > 200000)
            {
                Console.WriteLine("Максимальная сумма для перевода 200 000 рублей");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введиет правильную сумму");
                    a = int.Parse(Console.ReadLine());
                }
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            while (bank_balans - a < 0)
            {
                if (bank_balans - a < 0)
                {
                    Console.WriteLine($"Недостаточно средст для перевода. Ваш баланс {bank_balans}");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine($"Вы перевели на деньги счет: {login_transfer}.");
            bank.Transfer1(a);
        }
        private static void Deposit()
        {
            Console.WriteLine("Вклад 6.1%");
            Console.Write("Через сколько лет вы хотите узнать свой баланс:");
            int year_vklad = int.Parse(Console.ReadLine());
            double dep=0;
            for (int i = 0; i < year_vklad; i++)
            {
                dep=Math.Round(bank_balans+bank_balans*percent,2);
            }
            if (year_vklad >= 5)
            {
                Console.WriteLine($"Через {year_vklad} лет у вас будет {dep} рублей.");
            }
            else
            {
                Console.WriteLine($"Через {year_vklad} года у вас будет {dep} рублей.");
            }
        }
        private static void CheckBalance()
        {
            Console.WriteLine();
            Console.WriteLine($"Ваш баланс на текущий момент {bank_balans} рублей");
        }
        public void Operation()
        {
            int prov;
            int number_operation;
            Console.WriteLine("1.Зарегистрироваться");
            Console.WriteLine("2. Выйти");
            try
            {
                prov = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Введите правильное число ");
                prov = int.Parse(Console.ReadLine());
            }
            if (prov == 1)
            {
                FullName();
            }
            Console.WriteLine("Укажиет день рождение");
            Console.Write("День: ");
            day_birthday = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            month_birthday = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            year_birthday = int.Parse(Console.ReadLine());
            DateTime dataBorn = new DateTime(year_birthday, month_birthday, day_birthday);
            Console.WriteLine($"{dataBorn.Day}.{dataBorn.Month}.{dataBorn.Year}");
            if (DateTime.Now.Year - dataBorn.Year < 14)
            {
                Console.WriteLine("Люди младше 14 лет не могут открыть счет.");
            }
            else
            {
                Console.WriteLine("Выберите дальшейшие действие");
                Console.WriteLine("1. Пополнение счета");
                Console.WriteLine("2. Снятие денег со счета");
                Console.WriteLine("3. Перевод денег");
                Console.WriteLine("4. Узнать свой баланс");
                Console.WriteLine("5. Узнать свой депозит");
                Console.WriteLine("Выберите любое число для выхода");
                try
                {
                    number_operation = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите правильную сумму");
                    number_operation = int.Parse(Console.ReadLine());
                }
                while (number_operation > 0 && number_operation < 6)
                {
                    switch (number_operation)
                    {

                        case 1: Refill(bank_balans); break;
                        case 2: Withdrawal(); break;
                        case 3: Transfer(); break;
                        case 4: CheckBalance(); break;
                        case 5: Deposit(); break;
                    }
                    Console.WriteLine("Выберите дальнейшие действие");
                    try
                    {
                        number_operation = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите правильную сумму");
                        number_operation = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public static void A()
        {

            Bank bank = new Bank(0);
            Client client = new Client("Igor");
            Employee employee1 = new Employee("Timur");

            Console.WriteLine("1. Клиент");
            Console.WriteLine("2. Сотрудник");
            client._id = int.Parse(Console.ReadLine());
            if (client._id == 1)
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