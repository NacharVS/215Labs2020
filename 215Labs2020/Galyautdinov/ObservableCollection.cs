using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Galyautdinov
{
    class ObservableCollection
    {
        private static string Name;
        private static int Age;

        public ObservableCollection(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static void Run()
        {
            ObservableCollection<ObservableCollection> student = new ObservableCollection<ObservableCollection>
            {
            new ObservableCollection("Ислам", 50),
            new ObservableCollection("Ильяс", 33)
            };
            student.Add(new ObservableCollection("Виталий", 18));
            student.Add(new ObservableCollection("Володя", 17));
            student.Add(new ObservableCollection("Тимур", 18));
            student.Add(new ObservableCollection("Расиф", 17));

            student.CollectionChanged += StudentCollectionChanged;

            student.Add(new ObservableCollection("Алеша", 18));
            student.Add(new ObservableCollection("Ваня", 17));
            student.Remove(student[1]);
        }
        private static void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
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
