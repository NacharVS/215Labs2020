using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace _215Labs2020.Ilysov
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
            public static void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine("Added");
                }
                else
                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    Console.WriteLine("Removed");
                }
                else
                if (e.Action == NotifyCollectionChangedAction.Replace)
                {
                    Console.WriteLine("Replaxed");
                }
            }
            public static void Operation()
            {
                ObservableCollection<Observ> students = new ObservableCollection<Observ> { new Observ("Roman", 18), new Observ("Ivan", 20) };
                students.Add(new Observ("KOlya", 35));
                students.Add(new Observ("Petr", 14));

                students.CollectionChanged += StudentCollectionChanged;

                students.Add(new Observ("KOlya", 35));
                students.Remove(new Observ("Petr", 14));

            }
        }
    }

