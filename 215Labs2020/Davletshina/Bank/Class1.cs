using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _215Labs2020.Davletshina.Bank
{
    class Class1
    {
        private static string bname;
        private static string bsurname;
        private static int _vklad;
        private static int id;
        public static ArrayList Lid = new ArrayList();
        public static ArrayList Lnames = new ArrayList();
        public static ArrayList LSnames = new ArrayList();
        public static ArrayList LVklad = new ArrayList();

        //public string Name => bname;
        //public string Surname => bsurname;
        //public int _Vklad => _vklad;
        //public int Id => id;

        //public Class1(string _name, string _sname, int __id, int __vklad)
        //{
        //    bname = _name; _sname = bsurname; __id = id; __vklad = _vklad;
        //}
        public static void collections()
        {
            //List<Class1> baza1 = new List<Class1>();
            //baza1.Add(new Class1("Tom", "Hardy", 123, 156000));
            //List<Class1> baza2 = new List<Class1>();
            //baza2.Add(new Class1("Leysan", "Ilyasova", 228, 199000));

            //foreach (Class1 item in baza2)
            //{
            //    Console.WriteLine( item.Name ); 
            //}
            //int n = int.Parse(Console.ReadLine());
            //if ()
            Lid.Add(123); Lid.Add(007); Lid.Add(228);
            Lnames.Add("Cillian"); Lnames.Add("Tom"); Lnames.Add("James");
            LSnames.Add("Murfy"); LSnames.Add("Hardy"); LSnames.Add("Bond");
            LVklad.Add(159000); LVklad.Add(177000); LVklad.Add(190000);

            Console.WriteLine("Enter name");

        }
    }
}
