using System;


namespace _215Labs2020.Shakirovа
{
    class bank
    {
        private string _name;
        private string _surname;
        private int _summinvklad;
        private static double _procent =0.13;
        private double _dohod;
        private int _years;
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
        public double Dohod
        {
            get
            {
                _dohod = _summinvklad;
                for (int i = 0; i < _years; i++)
                {
                    _dohod = _dohod * _procent + _dohod;
                }
                return _dohod;
            }
            set
            {
                _dohod = summinvklad;
                _dohod = _dohod * _procent + _dohod;
            }
        }
        

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

                if (value >= 10000 & value < 200000)
                {
                    User.summinvklad = value;
                    k = 0;
                }
                if (value < 10000)
                {
                    Console.WriteLine("сумма должна быть меньше 10000");
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

            static void Nachalo()
            {
                int c = 0;
                int ii = 1;
                bank[] Accounts = new bank[ii];
                do
                {
                    for (int i = 0; i > ii; i++)
                    {

                        Accounts[i] = new bank();
                        bank.Reg(Accounts[i]);
                        Console.WriteLine($"{Accounts[i].Name} {Accounts[i].Surname} , у вас на счету {Accounts[i].summinvklad} руб.");
                        Console.WriteLine($"По истечению срока вклада на вашем счету будет {bank._procent} руб.");
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
    }
}
