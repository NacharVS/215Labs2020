using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Bank
{
    class Observv
    {
        private string name;
        private int age;


        public string Name => name;
        public int Age => age;


        public Observv(string _name, int _age)
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
            ObservableCollection<Observv> students = new ObservableCollection<Observv> { new Observv("Oleg", 24), new Observv("Danya", 19) };
            students.Add(new Observv("KOlya", 35));
            students.Add(new Observv("Petr", 14));

            students.CollectionChanged += StudentCollectionChanged;

            students.Add(new Observv("KOlya", 35));
            students.Remove(new Observv("Petr", 14));

        }
    }
}
    

