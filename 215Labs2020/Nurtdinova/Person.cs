using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova
{
    abstract class Person
    {
        public static string _SNP;
        public static string SNP
        {
            get
            {
                return _SNP;
            }
            set
            {
                _SNP = value;
            }
        }
        public static DateTime dateBorn { get; set; }
        public static int Id;
        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
         
    }
}
