using System;
using _215Labs2020.Galyautdinov;
using _215Labs2020.Galyautdinov.Bank_class;
using _215Labs2020.Galyautdinov.Delegates;
using _215Labs2020.Galyautdinov.StrategyGames;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020
{
    class Student
    {
        private static string Name { get; set; }
        private static int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Student> student = new ObservableCollection<Student>
            {
            new Student("Ислам", 50),
            new Student("Ильяс", 33)
            };
            student.Add(new Student("Виталий", 18));
            student.Add(new Student("Володя", 17));
            student.Add(new Student("Тимур", 18));
            student.Add(new Student("Расиф", 17));

            student.CollectionChanged += StudentCollectionChanged;

            student.Add(new Student("Алеша", 18));
            student.Add(new Student("Ваня", 17));
            student.Remove(student[1]);
        }
        private static void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Что-то добавлено");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Что-то удалено");
            }
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Что-то перемещено");
            }
        }
    }
}
