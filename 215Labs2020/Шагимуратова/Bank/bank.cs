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
        private string _phone;
        private int _summinvklad;
        private static double _procent = 0.13;
        private double _summa;
        private int _years;
        private static string _Patronymic;
        private static DateTime _dateOpen;
        private static int _shetchik;


        public delegate void Handler(string message);
        public event Handler Notify;
       
       
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
                if (value >= 10000 & value < 200000)
                {
                    _summinvklad = value;
                  
                }
                if (value < 10000)
                {
                    Console.WriteLine("сумма не должна быть меньше 10000");
                    
                }
                if (value >= 200000)
                {
                    Console.WriteLine("сумма не должна превышать 200000");

                }
            }
        }

        public static DateTime DateOpen { get => _dateOpen; set => _dateOpen = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public static void  Reg (List<bank> klients,int num) 
        {
            bank User = new bank();
            Boolean buf;
            DateOpen = new DateTime(DateTime.Now.Minute);
            Console.WriteLine("Введите имя");             User.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");         User.SurName = Console.ReadLine();
            Console.WriteLine("Введите Отчество");        User.Otchestvo = Console.ReadLine();
           
            do
            {
                Console.WriteLine("Введите день рождения: ");
                User.DayBD = int.Parse(Console.ReadLine());
                if (User.DayBD > 31 || User.DayBD < 1) buf = false;
            }while (buf = false);
            
            do
            {
               Console.WriteLine("Введите месяц рождения: ");
                User.MonhtBD = int.Parse(Console.ReadLine());
                if (User.MonhtBD > 12 || User.MonhtBD < 1)
                {
                    Console.WriteLine("Uncorrect value. Try again");
                    buf = true;
                }
            } while (buf = true);
            
            do
            {
                Console.WriteLine("Введите Год рождения: ");
                User.YearBD = int.Parse(Console.ReadLine());
                if (User.MonhtBD > 12 || User.MonhtBD < 1)
                { buf = true;
                    Console.WriteLine("Uncorrect value. Try again");
                }
            } while (buf = true);

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



        public int numer = 0;

        public bank()
        {

        }

        public bank(string name,string surname,int summinvklad, string phone,int db , int mb,int yb ,int pos)
        {
            this.Id = pos ;
            this.DayBD = db;
            this.MonhtBD = mb;
            this.YearBD = yb;
            this.Name = name;
            this.SurName = surname;
            this.summinvklad = summinvklad;
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
        }


        public static void setAny (List<bank> klients , string anyParams,int id, string move )
        {
            foreach (var item in klients)
            {
                if (item.Id==id)
                {
                    if (anyParams == "Name" || anyParams == "name")
                    { 
                     item.Name = move;
                    }
                    if (anyParams == "Surname" || anyParams == "surname" || anyParams == "SurName")
                    {
                     item.SurName = move;
                    }
                    if (anyParams=="Phone"||anyParams=="phone")
                    {
                        item.Phone = move;
                    }
                }
            }
        }

        private void setAny(List<bank> klients, string anyParams,string oldValue,string newValue)
        {
            if (anyParams == "Name" || anyParams == "name")
            {
                foreach (var item in klients)
                {
                    if (oldValue==item.Name)
                    {
                        item.Name = newValue;
                    }
                }
            }
            if (anyParams == "Surname" || anyParams == "surname" || anyParams == "SurName")
            {
                foreach (var item in klients)
                {
                    if (oldValue == item.SurName)
                    {
                        item.SurName = newValue;
                    }
                }
            }
            if (anyParams == "Phone" || anyParams == "phone")
            {
                foreach (var item in klients)
                {
                    if (oldValue == item.Phone)
                    {
                        item.Phone = newValue;
                    }
                }
            }
        }

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

   





}

