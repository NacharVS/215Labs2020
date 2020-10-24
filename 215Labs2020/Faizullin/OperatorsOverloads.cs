using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class OperatorsOverloads
    {
        private string _name;
        private int _mark;

        public OperatorsOverloads(string name, int mark)
        {
            _name = name;
            _mark = mark;
  
        }
        public static double operator +(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._mark + s2._mark;
        }
        public static double operator -(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._mark + s2._mark;
        }
        public static double operator *(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._mark + s2._mark;
        }
        public static double operator /(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._mark / s2._mark;
        }
        static void Main(string[] args)
        {
            OperatorsOverloads operatorsOverloads1 = new OperatorsOverloads(" 4");
        }
        
    }
}
