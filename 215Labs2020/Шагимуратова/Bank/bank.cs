using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

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
        private static DateTime _dateOpen;
      

        public delegate void Handler(string message);
        public event Handler Notify;
       
        //public bank( double Summ)
        //{
        //    _balans = Summ;
        //}

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

        public static DateTime DateOpen { get => _dateOpen; set => _dateOpen = value; }


        public static void  Reg (List<bank> klients,int num) 
        {
            bank User = new bank();
            Boolean buf;
            DateOpen = new DateTime(DateTime.Now.Minute);
            Console.WriteLine("Введите имя");
             User.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
           // String buffSurname = Console.ReadLine();
            User.SurName = Console.ReadLine();
            Console.Write("Введите Отчество");
            User.Otchestvo = Console.ReadLine();
            Console.Write("День: ");
            do
            { User.DayBD = int.Parse(Console.ReadLine());
                if (User.DayBD > 31 || User.DayBD < 1) buf = false;
            }
            while (buf = false);

            Console.Write("Месяц: ");
            //String buffMonthBD = Console.ReadLine();
             
            do
            {
                User.MonhtBD = int.Parse(Console.ReadLine());
                if (User.MonhtBD > 12 || User.MonhtBD < 1) buf = true;
            }
            while (buf = true);

            Console.Write("Год: ");

             User.YearBD = int.Parse(Console.ReadLine());

             User.Id = num; 

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
            klients.Add(User);
  
        }


        List<bank> kleints = new List<bank>();

        public int numer = 0;
        public static void Nachalo(List<bank> klients,int numer)
        {
            int c = 0;
            do
            {
                    bank.Reg(klients,numer);
                    
                    Console.WriteLine($"{klients[numer].Name} {klients[numer].SurName} , у вас на счету {klients[numer].summinvklad} ");
                    Console.WriteLine($"По истечению срока вклада на вашем счету будет 8888 руб.");
                   
                numer++;
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

    //public static void Delit(List<bank> klients, int numer)
    //{

    //}

    
  


}

