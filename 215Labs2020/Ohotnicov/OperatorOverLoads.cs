using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    class OperatorsOverLoads
    {
        private double _number1;
        private double _number2;
        public OperatorsOverLoads(double v1)
        {
            _number1 = v1;
        }
        public static double operator +(OperatorsOverLoads n1, OperatorsOverLoads n2)
        {
            return (n1._number1 + n2._number2);
            {

            }
        }
        static void Main(double[] args)
        {
            OperatorsOverLoads number1 = new OperatorsOverLoads (5) ;
            OperatorsOverLoads number2 = new OperatorsOverLoads(5);
            double sum = (number1 + number2);

        }
    }
}
