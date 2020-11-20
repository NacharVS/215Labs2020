using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова
{
    public class Stud
    {
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                if (name[0] == char.ToLower(name[0]))
                {
                    
                    
                }
                else
                {

                }
                
            }
        }
        public int age;
    }
    public class labWork
    {
        public static void StdInfo(Stud stud1)
        {
            Console.WriteLine(stud1.name);
            Console.WriteLine(stud1.age);
        }
        public static void vmestomain()
        {
            Stud stud1 = new Stud();
            Console.WriteLine("Введите фамилию");
            stud1.name = Console.ReadLine();
            stud1.age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{stud1.name}");

        }
    }
    
}
    

