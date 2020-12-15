using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace _215Labs2020.Safiullin.Task
{
    class User
    {
        public User(string name, int year)
        {
            string _name = name;
            int _year = year;
        }
    
        public static void Program()
        {
            ObservableCollection<User> users =
                new ObservableCollection<User>
                {
                    new User("Petr", 23),
                    new User("Dima", 44),
                };
            users.Add(new User("Volodya", 27));
            users.Add(new User("Sasha", 67));
            users.Add(new User("Sasha", 45));

            users.CollectionChanged += UserCollectionChanged;
            users.Add(new User ("Bob", 46));
            users.Add(new User("Tom", 12));
            users.RemoveAt(3);
        }

        private static void UserCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("_Что - то добавлено_");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("_Что - то удалено_");
            }
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("_Что - то изменили_");
            }
        }
    }
}
