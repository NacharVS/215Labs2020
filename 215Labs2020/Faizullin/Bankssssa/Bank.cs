using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using _215Labs2020.Faizullin.Bankssssa;

namespace _215Labs2020.Faizullin

{
    class Bank
    {
        public delegate void AccountHadler(string message);
        public event AccountHadler Notify;
        private DateTime _birth;
        private static string _SNF;
        private static string _PhoneNumber;
        private static string _id;
        private static double _contribution = 0;
        private static double _percent = 0.3;
        private static int _balans = 0;
        private static DateTime _accountOpenDate;
        private static ArrayList ListSNF = new ArrayList();
        private static ArrayList Listid = new ArrayList();
        //private static ArrayList Listbirth = new ArrayList();

        public void Bankk(int sum)
        {
            _balans = sum;
        }

        public int BALANSE { get; private set; }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void Put(int sum)
        {
            _balans = sum;
            Notify?.Invoke($"поступило: {sum} ");
        }
        public void Take(int sum)
        {

            if (_balans >= sum)
            {
                _balans -= sum;
                Notify?.Invoke($"снято: {sum} ");
            }
            else
            {
                Notify?.Invoke($"недостаточно средств: {sum} ");
            }
        }
        public void RegistDate()
        {
            Bank bank = new Bank();
            _accountOpenDate = DateTime.Now;
            Console.WriteLine($"Дaта регистрации {_accountOpenDate}");
        }
        public string phoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = phoneNumber;
            }
        }
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = id;
            }
        }
        public DateTime Birth
        {
            get
            {
                return _birth;
            }

            set
            {
                _birth = value;

                if (_birth.Year == DateTime.Now.Year || _birth.Year > DateTime.Now.Year - 14)
                {
                    throw new Exception("Извените , но вам меньше 14лет");

                }
                else
                {

                    Console.WriteLine("Можете внести депозит");
                }
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birth.Year;
            }

        }
        //public void Client()
        //{
        //    List<Client> clientList = new List<Client>();

        //    clientList.Add(new Client("hvjv"));
        //    clientList.Add(new Client("hvjv"));
        //    foreach (Client iteam in clientList)
        //    {
        //        Console.WriteLine(iteam);
        //    }
        //}

        public void Registration()
        {
            Console.WriteLine("Hello, welcome to our Bank.");
            Console.WriteLine("***************************");
            Console.WriteLine("Введите номер телефона");
            Console.WriteLine("**********************");
            _PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите id ");
            Console.WriteLine("**********************");
            _id = Console.ReadLine();
            Listid.Add(_id);

            Bank bank = new Bank();
            try
            {
                Console.WriteLine("Enter personal data");
                Console.WriteLine("***************");
                Bank._SNF = Console.ReadLine();
                ListSNF.Add(_SNF);
                Console.WriteLine("Enter date of birth");
                Console.WriteLine("***************");
                Console.Write("Введите дату рождения (17/06/1996):");
                string inputDate = Console.ReadLine();
                bank.Birth = Convert.ToDateTime(inputDate);
                Console.WriteLine("Ваш возвраст: {0}", bank.Age);
                //Listbirth.Add(_birth);

                //ArrayList list = new ArrayList();
                //string SNF = Console.ReadLine();
                //foreach (var iteam in list)
                //{
                //    Console.WriteLine(iteam);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
           



        }
        public void ListClient()
        {
            //ArrayList list = new ArrayList();
            //ListSNF.Add(_SNF);
            for (int v = 0; v < ListSNF.Count; v++)
            {
                Console.WriteLine($"SNF: {ListSNF[v]}");
                Console.WriteLine($"id: {Listid[v]}");
                //Console.WriteLine($"birth: {Listbirth[v]}");
                //Console.WriteLine();
            }
        }
        //public void Redaktiv()
        //{
        //    List<Client> clientList = new List<Client>();

        //    clientList.Add(new Client("popov", 12));
        //    clientList.Add(new Client("dfw", 1324));
        //    foreach (Client item in clientList)
        //    {
        //        Console.WriteLine(item._SNF);
        //        Console.WriteLine(item.ID);
        //    }
        //    //foreach (Client item in clientList)
        //    //{
        //    //    if (item._SNF == "popov")
        //    //    {
        //    //        int Redaktiv_id = int.Parse(Console.ReadLine());
        //    //    }
        //    //}
        //    //Console.WriteLine("******************************");
        //    //foreach (var item in clientList)
        //    //{
        //    //    Console.WriteLine(item._SNF);
        //    //    Console.WriteLine(item.ID);
        //    //}
        //}
        public void Redaktivv()
        {
            Console.WriteLine("введите id");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите номер редактирования");
            Console.WriteLine("1. SNF");
            //Console.WriteLine("2. Id");
            Console.WriteLine("3. Выход из редактирования");

            int wfwf = int.Parse(Console.ReadLine());
            while (wfwf < 2 && wfwf > 0)
            {
                switch (wfwf)
                {
                    case 1:
                    {
                            Console.Write("Введите новые данные:");
                            ListSNF[wfwf - 1] = Console.ReadLine();

                    }
                        break;

                }
                Console.WriteLine("3. Выход из редактирования");
                wfwf = int.Parse(Console.ReadLine());
            }
        }


        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the Deposit amount");
            Console.WriteLine("************************");
            double MONEY = int.Parse(Console.ReadLine());
            if (MONEY >= 10000 || MONEY <= 200000) Bank._contribution = MONEY;

        }
        //private void Operation2()
        //{
        //Bank bank = new Bank();
        //Console.WriteLine("Ведите сумму для снятия ");
        //_balans = Console.ReadLine();
        //}
        private void PROGNOZ()
        {
            Bank bank = new Bank();
            Console.WriteLine("Investment for how many years?");
            Console.WriteLine("************************");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                Bank._contribution += Bank._percent * Bank._contribution;

            }
        }
        private void END()
        {
            Bank bank = new Bank();
            Console.WriteLine($"After the period yiou specified will be {Bank._contribution} rubles ");
            Console.WriteLine($" {Bank._SNF} Thank you ,goodbye");
        }

        public static void Proverka()
        {
            Bank bank = new Bank();
            bank.Notify += DisplayMessage;
            bank.Put(20);
            bank.Take(70);
            bank.RegistDate();
            bank.Registration();
            bank.ListClient();
            //bank.Redaktiv();
            bank.Redaktivv();
            bank.Operation();
            bank.PROGNOZ();
            bank.END();
        }
    }
}
