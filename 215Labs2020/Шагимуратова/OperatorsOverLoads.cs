using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова
{
    class OperatorsOverLoads
    {
        private int _chislo1;
        //private int _chislo2;


        public OperatorsOverLoads(int ch1) //int ch2
        {
            _chislo1 = ch1;
            //_chislo2 = ch2;
            
        }
        public static OperatorsOverLoads operator+(OperatorsOverLoads c1, OperatorsOverLoads c2)
        {
            return c1 + c2;
        }
        
    }

}
