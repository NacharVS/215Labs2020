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
        private static int _procent;

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
                if (value>10000 & value<200000)
                _summinvklad = value;
                if (value < 10000)
                {
                    Console.WriteLine("сумма должна быть больше 10000");
                }
                if (value > 200000) 
                {
                    Console.WriteLine("сумма не должна превышать 200000");
                }

            }
        }
        
    }
}
