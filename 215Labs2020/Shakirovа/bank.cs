using System;


namespace _215Labs2020.Shakirovа
{
    class bank
    {
        private string _name;
        private string _surname;
        private int _summinvklad;
        private static double _procent = 1;
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
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
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
                _summinvklad = value;
            }
        }

        //public double Procent
        //{
        //    get
        //    {
        //        return _procent;
        //    }
        //    set
        //    {
        //        _procent = value;
        //    }
        //}

        public static void Reg(bank User)
        {
            Console.WriteLine("Введите имя ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию ");
            User.Surname = Console.ReadLine();

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
            static void procent()
            {
                bank Bank = new bank();
                Console.WriteLine("На сколько лет кладете вклад?");
                int coat = int.Parse(Console.ReadLine());
                for (int i = 1; i < coat; i++) ;
                {
                    bank._procent += bank._procent * bank._procent;
                }

            }
            static void Nachalo(int ii)
            {
                bank[] Accounts = new bank[ii];
                for (int i = 0; i > ii; i++)
                {
                    Accounts[i] = new bank();
                    bank.Reg(Accounts[i]);
                    Console.WriteLine($"{Accounts[i].Name} {Accounts[i].Surname} , у вас на счету {Accounts[i].summinvklad} руб.");
                    Console.WriteLine($"По истечению срока вклада на вашем счету будет {bank._procent} руб.");
                }
            }

        }
    }
}
