using System;
namespace _215Labs2020.Imamiev
{
    class Client:User
    {
        public int id { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public static void ShowName()
        {
            Console.WriteLine(Name);
        }
    }
}
