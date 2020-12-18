using _215Labs2020.Galyautdinov.Bank_class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _215Labs2020.Galyautdinov
{
    class Bank : Person
    {
        public static int chek_id { get; set; }
        private static double bank_balans = 0, percent = 0.001, cashback_percent = 0.05, cashback_partner_percent = 0.2, cashback = 0;
        private static DateTime _accountOpenDate;
        private static int Day_birthday, Month_birthday, Year_birthday, edit_id, id;
        private static string name, surname, phone;

        private static Dictionary<int, Bank> ClientList = new Dictionary<int, Bank>();
        private static List<double> ListBalans = new List<double>();

        public delegate void AccountHandler(string message);
        public static event AccountHandler Notify = (message) =>
        {
            Console.WriteLine($"\nНа номер {phone} было отправлено сообщение \nСообщение: {message}\n");
        };
        public Bank(string surname, string name, string phone, int Day_birthday, int Month_birthday, int Year_birthday)
        {
            SurName = surname;
            Name = name;
            Phone = phone;
            day_birthday = Day_birthday;
            month_birthday = Month_birthday;
            year_birthday = Year_birthday;
        }
        private static void FullName()
        {
            bank_balans = 0;
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Укажиет день рождение");
            Console.Write("День: ");
            Day_birthday = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            Month_birthday = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            Year_birthday = int.Parse(Console.ReadLine());
            Console.Write("Введите номер телефона: ");
            phone = Console.ReadLine();

            id+= 1;
            ClientList.Add(id, new Bank(surname, name, phone, Day_birthday, Month_birthday, Year_birthday));
            ListBalans.Add(bank_balans);
        }
        private static void ListOfClients()
        {
            foreach (var item in ClientList)
            {
                Console.WriteLine($"ID:{item.Key} {item.Value.SurName} {item.Value.Name} \nБаланс: {ListBalans[item.Key - 1]}");
                Console.WriteLine($"Номер телефона: {item.Value.Phone}");
                Console.WriteLine($"Дата рождения: {item.Value.day_birthday}.{item.Value.month_birthday}.{item.Value.year_birthday}");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
        }
        private static void Set_account()
        {
            ListOfClients();
            Console.Write("Введите ID ");
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
            Console.Write("Введите новое имя: ");
            foreach (var item in ClientList)
            {
                if (item.Key==edit_id)
                {
                    item.Value.Name = Console.ReadLine();
                }
            }
        }
        private static void EditSurName()
        {
            Console.Write("Введите новую фамилию: ");
            foreach (var item in ClientList)
            {
                if (item.Key == edit_id)
                {
                    item.Value.SurName = Console.ReadLine();
                }
            }
        }
        private static void EditPhone()
        {
            Console.Write("Введите новый номер: ");
            foreach (var item in ClientList)
            {
                if (item.Key == edit_id)
                {
                    item.Value.Phone = Console.ReadLine();
                }
            }
        }
        private static void EditDataBirthday()
        {
            foreach (var item in ClientList)
            {
                if (item.Key == edit_id)
                {
                    Console.Write("Введите день рождения: ");
                    item.Value.day_birthday = int.Parse(Console.ReadLine());
                    Console.Write("Введите месяц рождения: ");
                    item.Value.month_birthday = int.Parse(Console.ReadLine());
                    Console.Write("Введите год рождения: ");
                    item.Value.year_birthday = int.Parse(Console.ReadLine());
                }
            }
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
            ListBalans[ClientList.Count - 1] = bank_balans;
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
                ListBalans[ClientList.Count - 1] = bank_balans;
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
            ListBalans[ClientList.Count - 1] = bank_balans;
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
            ListBalans[ClientList.Count - 1] = bank_balans;
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

            DateTime dataBorn = new DateTime(Year_birthday, Month_birthday, Day_birthday);

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
                        case 9: Set_account(); break;
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
        public static void Run()
        {
            Console.WriteLine("1. Клиент");
            Console.WriteLine("2. Сотрудник");
            chek_id = int.Parse(Console.ReadLine());
            _accountOpenDate = DateTime.Now;
            if (chek_id == 1)
            {
                Operation();
            }
            else if (chek_id == 2)
            {
                Employee.employee();
            }
        }
    }
}