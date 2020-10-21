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
        private static int _procent = 13;
        //public int _id;
        //public static int chetchikID;

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
                _name = value;
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
                summinvklad = value;
                _summinvklad = summinvklad;
            }
        }
     
        public void Popolnenie()
        {
            Console.WriteLine("Введите сумму пополнения");
            int value = int.Parse(Console.ReadLine());
            int k = 0;
            do
            {
                if (value > 10000 & value < 200000)
                {
                    summinvklad = value;
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
            Console.WriteLine($" у вас на счету = {_summinvklad} рублей");
        }
        
    }
    
}  

