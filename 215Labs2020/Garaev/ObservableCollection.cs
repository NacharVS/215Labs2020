using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Garaev
{
    class Student1
    {
        private static string Name;
        private static int Age;
        public Student1(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class ObservableCollection
    {
        public static void Main1()
        {
            ObservableCollection<Student1> students = new ObservableCollection<Student1>
            {
                new Student1("Roman", 50),
                new Student1("Roman", 50)
            };
            students.Add(new Student1("Vitalik", 18));
            students.Add(new Student1("Vitalik", 24));

            students.CollectionChanged += StudentCollectionChanged;

            students.Add(new Student1("Vitalik", 21));
            students.Add(new Student1("Vitalik", 78));
            students.Remove(students[0]);
            Console.ReadLine();
        }
        static void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Something added");
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Something Removed");
            }
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Something Replaced");
            }
        }
    }
}
