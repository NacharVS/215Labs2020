using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова
{
    class bank
    {
        private string _name;
        private string _Surname;
        private int _summinvklad;
        private static double _procent = 0.13;
        //private string _id;
        //public static int _chetchikID = 0;
        
       
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string SurName
        {
            get
            {
                return _Surname;
            }
            set
            {
                //SurName = value;
                _Surname = value;
            }
        }
      
        public int summinvklad
        {
            get
            {
                return _summinvklad;
            }
            set
            {
                //summinvklad = value;
                _summinvklad = value;
            }
        }
        
        
        public static void Reg (bank User)
        {
            Console.WriteLine("Введите имя ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию ");
            User.SurName = Console.ReadLine();
            int k = 0;
            do
            {
                Console.WriteLine("Введите сумму пополнения");
                int value = int.Parse(Console.ReadLine());
               
                if (value > 10000 & value < 200000)
                {
                    User.summinvklad = value;
                    k = 0;
                }
                if (value < 10000)
                {
                    Console.WriteLine("сумма должна быть больше 10000");
                    k = 1;
                }
                if (value > 200000)
                {
                    Console.WriteLine("сумма не должна превышать 200000");
                    k = 1;
                }
            }
            while (k == 1);
            //Console.WriteLine($" у вас на счету = {User.summinvklad} рублей");
           
        }
        public static void Nachalo(int ii)
        {
            bank[] Accounts = new bank[ii];
            for (int i = 0; i > ii; i++)
            {
                Accounts[i] = new bank();
                bank.Reg(Accounts[i]);
                Console.WriteLine($"{Accounts[i].Name} {Accounts[i].SurName} , у вас на счету {Accounts[i].summinvklad} ");
            }

        }
    }
    
}  

