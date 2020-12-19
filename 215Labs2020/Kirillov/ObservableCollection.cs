using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Kirillov
{
    class ObservableCollection
    {
        private static string _name;
        private static int _age;

        public ObservableCollection(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public static void Start()
        {
            ObservableCollection<ObservableCollection> user = new ObservableCollection<ObservableCollection>
            {
                new ObservableCollection("Ivan", 17),
                new ObservableCollection("Oleg", 18)
            };
            user.Add(new ObservableCollection("Alexei", 20));
            user.Add(new ObservableCollection("Misha", 16));
            user.Add(new ObservableCollection("Vitaly", 21));
            user.Add(new ObservableCollection("Boris", 19));

            user.CollectionChanged += UserCollectionChanged;

            user.Add(new ObservableCollection("Sergei", 22));
            user.Add(new ObservableCollection("Dmitry", 21));
            user.Remove(user[2]);
        }
        private static void UserCollectionChanged(object notify, NotifyCollectionChangedEventArgs a)
        {
            if (a.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Something was added");
            }
            if (a.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Something was removed");
            }
            if (a.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Something was replaced");
            }
        }
    }
}    

    

