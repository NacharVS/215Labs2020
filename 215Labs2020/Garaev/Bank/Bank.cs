using System;
using System.Reflection.Metadata;
using System.Security;
using _215Labs2020.Garaev.Bank;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _Bank
{
    class Client: BankPerson
    {
        private static void Show_Messege1()
        {
            Console.WriteLine($"На счет поступило: {summ}");
        }
        private static void Show_Messege2()
        {
            Console.WriteLine($"Со счета выведено: {_vivod}");
        }
        private static void Show_Messege3()
        {
            Console.WriteLine($"Со счета переведено: {summ1}");
        }
        public delegate void AccountHandler();
        //public  event AccountHandler Notify;
        public Client(double sum)
        {
            balans = sum;
        }
        // сумма на счете
        public static double balans { get; private set; }
        // добавление средств на счет
        public void Put(double sum)
        {
            balans += sum;
            AccountHandler messege = () => Show_Messege1();
            messege();
            //Notify?.Invoke($"На счет поступило: {summ}");
        }
        //списание средств со счета
        public void Take(double sum)
        {
            if (balans >= sum)
            {
                balans -= sum;
                AccountHandler messege = () => Show_Messege2();
                messege();
            }
        }
        public void perevod(double sum)
        {
            if (balans >= sum)
            {
                balans -= sum;
                AccountHandler messege = () => Show_Messege3();
                messege();
            }
        }
        private static DateTime _accountOpenDate;

        private static void popolnenie_cashback()
        {
                balans += cashback;
                cashback = 0;
        }

        private static double cashback = 0;
        private static int dayofbirth = 0;
        private static int monthofbirth = 0;
        private static int yearofbirth = 0;
        private static double procent = 20;
        private static double cashback_procent = 5;
        private static double cashback_partner_procent = 20;
        private static string surname;
        private static string name;
        private static string otchestvo;
        private static int ID;
        private static int summ = 0;
        private static int _vivod = 0;
        private static int summ1 = 0;
        private static int nomer = 0;
        private static int a = 0;
        private static int year = 0;
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public Client(string name)
        { 

        }
        private static List<Client> list = new List<Client>();
        //private static List<int> ID_list = new List<int>();
        //private static List<string> Surname_list = new List<string>();
        //private static List<string> Name_list = new List<string>();
        //private static List<string> Otchestvo_list = new List<string>();
        //private static List<double> Balans_list = new List<double>();
        //private static List<string> Registrate_Data = new List<string>();
        private static void chek_accounts()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}){list[i]._name}");
                //Console.WriteLine($"   ID номер: {ID_list[i]}");
                //Console.WriteLine($"   Фамилия: {Surname_list[i]}");
                //Console.WriteLine($"   Имя: {Name_list[i]}");
                //Console.WriteLine($"   Отчество: {Otchestvo_list[i]}");
                //Console.WriteLine($"   Баланс: {Balans_list[i]}");
                Console.WriteLine();
            }
        }
        private static void set_account()
        {
            Console.Write("Введите ID пользователя, у которого хотите отредактировать профиль");
            int select_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Что хотите отредактировать?");
            Console.WriteLine("1) Фамилию");
            Console.WriteLine("2) Имя");
            Console.WriteLine("3) Отчество");
            Console.WriteLine("4) Выйти");
            int select = int.Parse(Console.ReadLine());
            while (select<4 && select > 0)
            {
                switch (select)
                {
                    case 1:
                        {
                            Console.Write("Введите новую фамилию: ");
                            //Surname_list[select_id-1] = Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введите новое имя: ");
                            //Name_list[select_id-1] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Введите новое отчество: ");
                            //Otchestvo_list[select_id-1] = Console.ReadLine();
                        }
                        break;
                }
                Console.WriteLine("Что хотите отредактировать?");
                Console.WriteLine("1) Фамилию");
                Console.WriteLine("2) Имя");
                Console.WriteLine("3) Отчество");
                Console.WriteLine("4) Выйти");
                select = int.Parse(Console.ReadLine());
            }

            
        }
        private static void dataofbirth()
        {
            balans = 0;
            _accountOpenDate = new DateTime(DateTime.Now.Minute);
            //Registrate_Data.Add($"Дата регистрации: {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} Время регистрации: {DateTime.Now.Hour}:{DateTime.Now.Minute}.{DateTime.Now.Second}");
            //Console.Write("Введите Фамилия: ");
            //surname = Console.ReadLine();
            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите Отчество: ");
            //otchestvo = Console.ReadLine();
            Console.WriteLine("Введите дату рождение");
            Console.Write("День: ");
            dayofbirth = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            monthofbirth = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            yearofbirth = int.Parse(Console.ReadLine());
            int realyear = DateTime.Now.Year;
            int realday = DateTime.Now.Day;
            int realmonth = DateTime.Now.Month;
            
            bool l = true;
            while (l == true)
            {
                int age = realyear - yearofbirth;
                if (age == 14)
                {
                    if (realmonth >= monthofbirth)
                    {
                        if (realday >= dayofbirth)
                        {
                            l = false;
                        }
                        else
                        {
                            Console.WriteLine("Извиние. Открыть счет могут только лица достигшие 14 лет");
                            Console.Write("День: ");
                            dayofbirth = int.Parse(Console.ReadLine());
                            Console.Write("Месяц: ");
                            monthofbirth = int.Parse(Console.ReadLine());
                            Console.Write("Год: ");
                            yearofbirth = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Извиние. Открыть счет могут только лица достигшие 14 лет");
                        Console.Write("День: ");
                        dayofbirth = int.Parse(Console.ReadLine());
                        Console.Write("Месяц: ");
                        monthofbirth = int.Parse(Console.ReadLine());
                        Console.Write("Год: ");
                        yearofbirth = int.Parse(Console.ReadLine());
                    }
                }
                else if (age > 14)
                    l = false;
                else
                {
                    Console.WriteLine("Извиние. Открыть счет могут только лица достигшие 14 лет");
                    Console.Write("День: ");
                    dayofbirth = int.Parse(Console.ReadLine());
                    Console.Write("Месяц: ");
                    monthofbirth = int.Parse(Console.ReadLine());
                    Console.Write("Год: ");
                    yearofbirth = int.Parse(Console.ReadLine());
                }
            }
            list.Add(new Client() );
            //ID += 1;
            //ID_list.Add(ID);
            //Surname_list.Add(surname);
            //Name_list.Add(name);
            //Otchestvo_list.Add(otchestvo);
            //Balans_list.Add(balans);
            //_surname = surname;
            //_name = name;
            //_otchestvo = otchestvo;
        }
        private static void bank_account()
        {
            if (DateTime.Now.Minute > _accountOpenDate.Minute)
            {
                balans += cashback;
                cashback = 0;
            }
            Client acc = new Client(balans);
            //acc.Notify += DisplayMessage;

            Console.Write("Введите сумму пополнения: ");
            int f = 0;
            while (f==0)
            {
                try
                {
                    summ = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильную сумму: ");
                    f = 0;
                }
            }
            while (summ>200000 || summ < 10000)
            {  
                summ = 0;
                Console.WriteLine("Вы превысили лимит пополнения в 200 000 или сумма пополнения меньше 10 000");
                Console.Write("Введите сумму пополнения: ");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        summ = int.Parse(Console.ReadLine());
                        f1 += 1;
                   }
                    catch
                    {
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
            acc.Put(summ);
            Console.WriteLine($"Ваш текущий баланс: {balans}");
            //Balans_list[Name_list.Count - 1] = balans;
        }
        private static void vivod()
        {
            Client acc = new Client(balans);
            Console.Write("Сколько денег хотите вывести: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    _vivod = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильную сумму: ");
                    f = 0;
                }
            }
            while (balans - _vivod < 0 || _vivod > 200000 || (_vivod < 10000 && _vivod != 0))
            {
                if (balans - _vivod < 0)
                    Console.WriteLine("На вашем счету недостаточно средств");
                else if (_vivod > 200000 || _vivod < 10000)
                {
                    Console.WriteLine("Минимальный вывод: 10 000 руб.");
                    Console.WriteLine("Максимальный вывод: 200 000 руб.");
                }
                Console.Write("Сколько денег хотите вывести: ");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        _vivod = int.Parse(Console.ReadLine());
                        f1 += 1;
                    }
                    catch
                    {
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
            acc.Take(_vivod);
            Console.WriteLine($"Ваш текущий баланс: {balans}");
            //Balans_list[Name_list.Count - 1] = balans;
        }
        private static void transaction()
        {
            Client acc = new Client(balans);
            Console.Write("Введите номер счета на которую хотите перевести: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    nomer = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильный номер: ");
                    f = 0;
                }
            }
            Console.Write("Сколько денег хотите перевести: ");
            int f1 = 0;
            while (f1 == 0)
            {
                try
                {
                    summ1 = int.Parse(Console.ReadLine());
                    f1 += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильную сумму: ");
                    f1 = 0;
                }
            }
            while (balans - summ1 < 0 || summ1 > 200000 || (summ1 < 10000 && summ1 != 0))
            {
                if (balans - summ1 < 0)
                { 
                    Console.WriteLine("На вашем счету недостаточно средств");
                }
                else if (summ1 > 200000 || summ1 < 10000)
                {
                    Console.WriteLine("Минимальный перевод: 10 000 руб.");
                    Console.WriteLine("Максимальный перевод: 200 000 руб.");
                }
                Console.Write("Сколько денег хотите перевести: ");
                int f2 = 0;
                while (f2 == 0)
                {
                    try
                    {
                        summ1 = int.Parse(Console.ReadLine());
                        f2 += 1;
                    }
                    catch
                    {
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f2 = 0;
                    }
                }
            }
            Console.WriteLine($"Вы перевели {summ1} руб. на счет {nomer}");
            acc.perevod(summ1);
            Console.WriteLine($"Ваш текущий баланс: {balans}");
            //Balans_list[Name_list.Count - 1] = balans;
        }
        private static void _dohod()
        {
            Console.WriteLine($"Процентная ставка: {procent}%");
            Console.Write("На сколько лет хотите посчитать проценты: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    year = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильно: ");
                    f = 0;
                }
            }
            double balans1 = balans;
            for (int i = 0; i < year; i++)
            {
                balans1 = Math.Round(balans1 + (balans1 * (procent / 100)),2);
            }
            double dohod = Math.Round(balans1-balans,2);
            if (year < 5)
            {
                Console.WriteLine($"Через {year} года ваш баланс будет {balans1} руб. Чистый доход: {dohod} руб.");
            }
            else
            {
                Console.WriteLine($"Через {year} лет ваш баланс будет {balans1} руб. Чистый доход: {dohod} руб.");
            }
            //Balans_list[Name_list.Count - 1] = balans;
        }
        private static void tecush_balans()
        {
            Console.WriteLine($"Ваш текущий баланс: {balans} руб.");
            //Balans_list[Name_list.Count - 1] = balans;
        }
        private static void pucupka()
        {
            popolnenie_cashback();
            Console.WriteLine("Выберите");
            Console.WriteLine($"1) Покупка от партнеров ({cashback_partner_procent} %)");
            Console.WriteLine($"2) Обычная покупка ({cashback_procent} %)");
            int casbac_select = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму покупки: ");
            int summ_pocupka = int.Parse(Console.ReadLine());
            if (summ_pocupka > balans)
            {
                Console.WriteLine("Не удалось совершить покупку так как недостаточно средств");
            }
            else
            {
                if (casbac_select == 1)
                    cashback += summ_pocupka * cashback_partner_procent / 100;
                else
                    cashback += summ_pocupka * cashback_procent / 100;
                balans -= summ_pocupka;
                Console.WriteLine($"Совершена покупка на {summ_pocupka} рублей");
            }
            
            popolnenie_cashback();
            //Balans_list[Name_list.Count - 1] = balans;
        }
        public static void vibor_deistviy()
        {
            Console.WriteLine("Здравствуйте вас приветствует наш банк");
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1) Зарегистрироваться");
            Console.WriteLine("2) Выйти");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильный номерр действия: ");
                    f = 0;
                }
            }
            if (a == 2)
                a = 0;
            while (a > 0 && a < 10)
            {
                switch (a)
                {
                    case 1: dataofbirth(); break;
                    case 2: bank_account(); break;
                    case 3: vivod();  break;
                    case 4: transaction(); break;
                    case 5: _dohod(); break;
                    case 6: tecush_balans(); break;
                    case 7: pucupka(); break;
                    case 8: chek_accounts(); break;
                    case 9: set_account(); break;
                }
                Console.WriteLine();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1) Зарегистрироваться");
                Console.WriteLine("2) Пополнить лицевой счет");
                Console.WriteLine("3) Вывести (Если захотите отменить операцию, то выведите 0 руб.)");
                Console.WriteLine("4) Перевод денег на другой лицевой счет (Если захотите отменить операцию, то переведите 0 руб.)");
                Console.WriteLine("5) Посчитать проценты");
                Console.WriteLine("6) Узнать текущий баланс");
                Console.WriteLine("7) Покупка");
                Console.WriteLine("8) Просмотр зарегистрированных пользователей");
                Console.WriteLine("9) Редактирование профиля");
                Console.WriteLine("10) Выйти");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        f1 = 1;
                    }
                    catch
                    {
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильное действие: ");
                        f1 = 0;
                    }
                }
            }
            BankPerson.Bank_deysviya();
        }
    }
}
