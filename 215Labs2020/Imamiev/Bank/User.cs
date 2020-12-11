using System;
namespace _215Labs2020.Imamiev
{
    abstract class User
    {
        public static string name;
        public static string name2;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static string Name2
        {
            get
            {
                return name2;
            }
            set
            {
                name2 = value;
            }
        }
    }
}
    

