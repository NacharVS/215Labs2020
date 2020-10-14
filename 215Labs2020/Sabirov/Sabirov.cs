using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class StudentsBaseGetSet
    {
        private string name;
        private int marks;

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if (value < 2) marks = 2;
                else if (value > 5) marks = 5;
                else marks = value;
            }
        }
    public static void StudBD()
        {
            StudentsBaseGetSet[] names = new StudentsBaseGetSet[5];
            StudentsBaseGetSet[] marks = new StudentsBaseGetSet[3];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = new StudentsBaseGetSet();
            }
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = new StudentsBaseGetSet();
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name");
                names[i].name = Console.ReadLine();
                Console.WriteLine("First mark");
                marks[0].marks = int.Parse(Console.ReadLine());
                Console.WriteLine("Second mark");
                marks[1].marks = int.Parse(Console.ReadLine());
                Console.WriteLine("Third mark");
                marks[2].marks = int.Parse(Console.ReadLine());
                Console.WriteLine($"{names[i].name}, {marks[0].Marks}, {marks[1].Marks}, {marks[2].Marks} ");
                
                //Console.WriteLine($"Average marks for {names[i].name} is {av}");
            }
        }    
    }
    
}
