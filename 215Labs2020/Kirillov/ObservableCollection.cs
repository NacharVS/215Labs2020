using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Kirillov
{
    class Observ
    {
        private string name;
        private int age;
        
    
        public string Name => name;
        public int Age => age;

        
        public Observ(string _name, int _age)
        {
            name = _name;
            age = _age;

        }
        public static void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs a)
        {
            if (a.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Added");
            }

            if (a.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Removed");
            }
            else
            if (a.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Replaxed");
            }
        }
        public static void Operation()
        {
            ObservableCollection<Observ> students = new ObservableCollection<Observ> { new Observ("Oleg", 17), new Observ("Ivan", 25) };
            students.Add(new Observ("Maxim", 19));
            students.Add(new Observ("Petr", 26));

            students.CollectionChanged += StudentCollectionChanged;

            students.Add(new Observ("Maxim", 19));
            students.Remove(new Observ ("Oleg", 17));
        }
    }
}
    

