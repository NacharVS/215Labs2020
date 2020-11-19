using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Bank
{
    class bank:Human
    {
       
        private static double _balans;
        private static double _cashback = 0;
        private static long _phone;
        private int _summinvklad;
        private static double _procent = 0.13;
        private double _summa;
        private int _years;
        private static string _Patronymic;
        private static string _dayB;
        private static string _mounthB;
        private static string _yearB;
       
        public delegate void Handler(string message);
        public event Handler Notify;
       
        public  bank( double Summ)
        {
            _balans = Summ;
        }
       public void came_money(double Summ)
        {
            _balans += Summ;
            Notify?.Invoke($"came money: {Summ}");
        }
        public void withdrew_money (double Summ)
        {
            _balans -= Summ;
            Notify?.Invoke($"withdrew money: {Summ}");
        }
        public void came_cashback(double Summ)
        {
            _balans += Summ;
            Notify?.Invoke($"came cashback:{Summ}");
        }
        public void money_transfer(double Summ)
        {
            _balans -= Summ;
            Notify?.Invoke($"money transfer:{Summ}");
        }

    public int summinvklad
        {
            get
            {
                return _summinvklad;
            }
            set
            {
                _summinvklad = value;
            }
        }
       
        public static void Reg (bank User)
        {
            Console.WriteLine("Введите имя ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию ");
            User.SurName = Console.ReadLine();
            Console.Write("Введите Отчество ");
            User._ = Console.ReadLine();
            Console.Write("День: ");
             = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            monthofbirth = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            yearofbirth = int.Parse(Console.ReadLine());
            int k=0;
            do
            {
                Console.WriteLine("Введите сумму пополнения");
                int value = int.Parse(Console.ReadLine());
               
                if (value >= 10000 & value < 200000)
                {
                    User.summinvklad = value;
                    k = 0;
                }
                if (value < 10000)
                {
                    Console.WriteLine("сумма не должна быть меньше 10000");
                    k = 1;
                }
                if (value >= 200000)
                {
                    Console.WriteLine("сумма не должна превышать 200000");
                    k = 1;
                }
            }
            while (k == 1);
            k = 0;
            do
            {
                Console.WriteLine("На какой срок вы хотите положить вклад?");
                int value = int.Parse(Console.ReadLine());

                if (value >= 2 & value < 20)
                {
                    User._years = value;
                    k = 0;
                }
                if (value < 2)
                {
                    Console.WriteLine("Не менее двух лет");
                    k = 1;
                }
                if (value >= 20)
                {
                    Console.WriteLine("Не больше 20 лет");
                    k = 1;
                }
            }
            while (k == 1);
            
           


        }
        public static void Nachalo()
        {
            int c = 0;
            int ii = 1;
            bank[] Accounts = new bank[ii];
            do
            {
                for (int i = 0; i < ii; i++)
                {
                    Accounts[i] = new bank();
                    bank.Reg(Accounts[i]);
                    Console.WriteLine($"{Accounts[i].Name} {Accounts[i].SurName} , у вас на счету {Accounts[i].summinvklad} ");
                    Console.WriteLine($"По истечению срока вклада на вашем счету будет {Accounts[i].Summa} руб.");
                }
                Console.WriteLine("Вы хотите зарегистрировать еще одного юзера? нажмите 1-да , 2 - нет");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    c = 1;
                }
            }
            while (c == 1);
        }
    }
    
    //static void M (string[] args)
    //{
    //    int c;
    //    int ii = 1;
    //    bank[] Users = new bank[ii];
    //    do
    //    {
    //        for (int i = 0; i < ii; i++)
    //        {
    //            Users[i] = new bank();
    //            bank.Reg(Users[i]);
    //            Console.WriteLine($"{Users[i].Name} {Users[i].SurName} , у вас на счету {Users[i].summinvklad} ");
    //        }
    //        Console.WriteLine("Вы хотите зарегистрировать еще одного юзера? нажмите 1-да , 2 - нет");
    //        int choose = int.Parse(Console.ReadLine());
    //        if (choose == 1) c = 1;
    //    } while (c == 1);

    //}


}

