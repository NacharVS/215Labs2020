using _215Labs2020.Galyautdinov.Bank_class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _215Labs2020.Galyautdinov
{
    class Bank : Person
    {
        private static double bank_balans = 0;
        private static double percent = 0.001;
        private static double cashback_percent = 0.05;
        private static double cashback_partner_percent = 0.2;
        private static double cashback = 0;
        private static DateTime _accountOpenDate;
        private static string Phone;
        private static int day_birthday;
        private static int month_birthday;
        private static int year_birthday;
        private static int edit_id;

        private static List<Bank> List_Name = new List<Bank>();
        private static ArrayList ListName = new ArrayList();
        private static ArrayList ListBa1lans = new ArrayList();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListSurName = new ArrayList();
        private static ArrayList ListPhone = new ArrayList();

        static Person person = new Person();
        private static Dictionary<int, Bank> ClientList = new Dictionary<int, Bank>();
        private static List<double> ListBalans = new List<double>();

        public delegate void AccountHandler(string message);
        public static event AccountHandler Notify = (message) =>
        {
            Console.WriteLine($"\nНа номер {Phone} было отправлено сообщение \nСообщение: {message}\n");
        };
        public Bank(string surname, string name, string phone, int _day_birthday, int _month_birthday, int _year_birthday)
        {
            SurName = surname;
            Name = name;
            Phone = phone;
            day_birthday = _day_birthday;
            month_birthday = _month_birthday;
            year_birthday = _year_birthday;
        }
        private static void FullName()
        {
            bank_balans = 0;
            Console.Write("Введите фамилию: ");
            person.SurName = Console.ReadLine();
            Console.Write("Введите имя: ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Укажиет день рождение");
            Console.Write("День: ");
            day_birthday = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            month_birthday = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            year_birthday = int.Parse(Console.ReadLine());
            Console.Write("Введите номер телефона: ");
            Phone = Console.ReadLine();

            person.ID += 1;
            ClientList.Add(person.ID, new Bank(person.SurName, person.Name, Phone, day_birthday, month_birthday, year_birthday));
            ListBalans.Add(bank_balans);

        }
        private static void ListOfClients()
        {
            foreach (var item in ClientList)
            {
                Console.WriteLine($"ID: {item.Key}");
                Console.WriteLine($"ФИ: {item.Value.SurName}, {item.Value.Name}");
                Console.WriteLine($"Bаш баланс: {ListBalans[item.Key-1]}");
            }
        }
        private static void set_account()
        {
            Console.WriteLine("Введите ID ");
            edit_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите параметр для редактирования ");
            Console.WriteLine("1. Фамилия\n2. Имя\n3. Номер\n4. Дата рождения\n5. Выход из редактирования");

            int proverka_reg = int.Parse(Console.ReadLine());
            while(proverka_reg<5 && proverka_reg > 0)
            {
                if (proverka_reg == 1)
                    EditSurName();
                else if (proverka_reg == 2)
                    EditName();
                else if (proverka_reg == 3)
                    EditPhone();
                else if (proverka_reg == 4)
                    EditDataBirthday();
                
                Console.WriteLine("Выберите параметр для редактирования ");
                Console.WriteLine("1. Фамилия\n2. Имя\n3. Номер\n4. Дата рождения\n5. Выход из редактирования");
                proverka_reg = int.Parse(Console.ReadLine());
            }
        }
        private static void EditName()
        {
            Console.Write("Введите новую имю: ");
            //ListName[edit_id - 1] = Console.ReadLine();

        }
        private static void EditSurName()
        {
            Console.Write("Введите новую фамилию: ");
            //ListSurName[edit_id - 1] = Console.ReadLine();
        }
        private static void EditPhone()
        {
            Console.Write("Введите новый номер: ");
            //ListPhone[edit_id - 1] = Console.ReadLine();
        }
        private static void EditDataBirthday()
        {
            Console.Write("Скоро будет!");
            Console.WriteLine();
        }
        private static void Refill()
        {
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
            Notify?.Invoke($"Пополнение баланса на сумму {a} рублей. Ваш  баланс: {bank_balans}");
            ListBalans[ClientList.Count-1] = bank_balans;
        }
        private static void Withdrawal()
        {
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
                Notify?.Invoke($"Со счета был снят {a} рублей. Ваш  баланс: {bank_balans}");
            }
            //ListBalans[person.ID] = bank_balans;
        }
        private static void Transfer()
        {
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
            if (bank_balans >= a)
            {
                bank_balans -= a;
                Notify?.Invoke($"Был осуществлен перевод на счет {login_transfer} на сумма {a} рублей. Ваш баланс {bank_balans} рублей.");
               // ListBalans[person.ID] = bank_balans;
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
                Console.WriteLine($"Недостаточно средств для покупки. Ваш баланс {bank_balans}");
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
            Notify?.Invoke($"Осуществлена покупка на сумму {a}  рублей. Ваш  баланс: {bank_balans}");
            if (id == 1)
            {
                cashback += a * cashback_partner_percent;
                bank_balans += cashback;
                Notify?.Invoke($"Начислен кешбек {cashback} рублей. Ваш  баланс: {bank_balans}");
            }
            else if (id == 2)
            {
                cashback += a * cashback_percent;
                bank_balans += cashback;
                Notify?.Invoke($"Начислен кешбек {cashback} рублей. Ваш  баланс: {bank_balans}");
            }
            cashback = 0;
            //ListBalans[person.ID] = bank_balans;
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
            Notify?.Invoke($"Начислена  процентная ставка. Ваш  баланс: {bank_balans}");
            //ListBalans[person.ID] = bank_balans;
        }
        private static void CheckBalance()
        {
            Console.WriteLine();
            Console.WriteLine($"Ваш баланс на текущий момент {bank_balans} рублей");
        }
        private static void Operation()
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

            DateTime dataBorn = new DateTime(year_birthday, month_birthday, day_birthday);

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
                Console.WriteLine("7. Список клиентов");
                Console.WriteLine("8. Зарегистрировать нового клиента");
                Console.WriteLine("9. Редактировать данные клиента");
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
                while (number_operation > 0 && number_operation < 10)
                {
                    switch (number_operation)
                    {
                        case 1: Refill(); break;
                        case 2: Withdrawal(); break;
                        case 3: Transfer(); break;
                        case 4: Purchase(); break;
                        case 5: CheckBalance(); break;
                        case 6: PeriodProfit(bank_balans); break;
                        case 7: ListOfClients(); break;
                        case 8: FullName(); break;
                        case 9: set_account(); break;
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
            Client client = new Client();
            Employee employee1 = new Employee();

            Console.WriteLine("1. Клиент");
            Console.WriteLine("2. Сотрудник");
            client._id = int.Parse(Console.ReadLine());
            _accountOpenDate = DateTime.Now;
            if (client._id == 1)
            {
                Operation();
            }
            else if (client._id == 2)
            {
                Employee.employee();
            }
        }
    }
}