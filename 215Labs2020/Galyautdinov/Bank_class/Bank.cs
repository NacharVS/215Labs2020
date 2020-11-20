using _215Labs2020.Galyautdinov.Bank_class;
using System;
using System.Threading.Tasks;

namespace _215Labs2020.Galyautdinov
{
    class Bank
    {
        private static double bank_balans = 0;
        private static double percent = 0.001;
        private static double cashback_percent = 0.05;
        private static double cashback_partner_percent = 0.2;
        private static double cashback = 0;
        private static DateTime _accountOpenDate;
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
        public static double Sum { get; private set; }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void FullName()
        {
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
        private static void Refill()
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
            bank_balans += a;
            bank.Notify?.Invoke($"На счет поступило: {a}");
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
            if (bank_balans >= a)
            {
                bank_balans -= a;
                bank.Notify?.Invoke($"Со счета снято: {a}");
            }
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
            if (bank_balans >= a)
            {
                bank_balans -= a;
                bank.Notify?.Invoke($"Осуществлен перевод на  {a} рублей.");
            }

        }
        public static void Purchase()
        {
            int a;
            Console.WriteLine("\t 1. Покупка у партнера || 2. Обычная покупка");
            Console.Write("Выберите вид покупки: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите сумму покупки: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (bank_balans - a < 0)
            {
                Console.WriteLine($"Недостаточно средст для покупки. Ваш баланс {bank_balans}");
                Console.Write("Выберите товары на меньшую сумму: ");
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
            bank_balans -= a;
            Console.WriteLine($"Осуществлена покупка на сумму {a}  рублей");
            if (id == 1)
            {
                cashback += a * cashback_partner_percent;
                bank_balans += cashback;
                Console.WriteLine($"Начислен кешбек {cashback} рублей. Ваш баланс: {bank_balans}");
            }
            else if (id == 2)
            {
                cashback += a * cashback_percent;
                bank_balans += cashback;
                Console.WriteLine($"Начислен кешбек {cashback} рублей. Ваш баланс: {bank_balans}");
            }
            cashback = 0;
        }
        private static void PeriodProfit(double bank_balans)
        {
            int second = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int secondOpen = _accountOpenDate.Hour * 3600 + _accountOpenDate.Minute * 60 + _accountOpenDate.Second;
            int deltaTime = second - secondOpen;
            int period = 10;
            period = deltaTime / period;
            for (int i = 0; i < period; i++)
            {
                bank_balans = Math.Round(bank_balans + bank_balans * percent, 2);
            }
            Console.WriteLine(bank_balans);
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
            Console.Clear();
            _accountOpenDate = DateTime.Now;
            Console.WriteLine($"Дата открытия счета {_accountOpenDate} ");
            Console.WriteLine(Person.Name);
            Console.WriteLine($"Ваш номер телефона: {phone}");
            DateTime dataBorn = new DateTime(year_birthday, month_birthday, day_birthday);
            Console.WriteLine($"Дата рождения: {dataBorn.Day}.{dataBorn.Month}.{dataBorn.Year}");
            Console.WriteLine();
            if (DateTime.Now.Year - dataBorn.Year < 14)
            {
                Console.WriteLine("Люди младше 14 лет не могут открыть счет.");
            }
            else
            {
                Console.WriteLine("1. Пополнение счета");
                Console.WriteLine("2. Снятие денег со счета");
                Console.WriteLine("3. Перевод денег");
                Console.WriteLine("4. Совершить покупку");
                Console.WriteLine("5. Узнать свой баланс");
                Console.WriteLine("6. Процентный остаток");
                Console.WriteLine("\t Выберите любое число для выхода");
                Console.WriteLine();
                Console.Write("Выберите дальшейшие действие ");
                try
                {
                    number_operation = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите правильную сумму");
                    number_operation = int.Parse(Console.ReadLine());
                }
                while (number_operation > 0 && number_operation < 7)
                {
                    switch (number_operation)
                    {

                        case 1: Refill(); break;
                        case 2: Withdrawal(); break;
                        case 3: Transfer(); break;
                        case 4: Purchase(); break;
                        case 5: CheckBalance(); break;
                        case 6: PeriodProfit(bank_balans); break;
                        
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
            Client client = new Client("Николавев Игорь Алексеевич");
            Employee employee1 = new Employee("Ильясов Тимур Искандерович");

            Console.WriteLine("1. Клиент");
            Console.WriteLine("2. Сотрудник");
            client._id = int.Parse(Console.ReadLine());
            _accountOpenDate = DateTime.Now;
            if (client._id == 1)
            {
                bank.Operation();
            }
            else if (client._id == 2)
            {
                Employee.employee();
            }
        }
    }
}