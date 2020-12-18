using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Ibragimov
{
    class observable
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public observable(string _name, int _age)
        {
            Name = _name;
            Age = _age;


        }
        static void User()
        {
            ObservableCollection<observable> a = new ObservableCollection<observable>
            {
              new observable("Roman" ,18),
              new observable("Yremovich" ,35)
            };

            a.Add(new observable("Махмудахмадинеджад", 43));
            a.Add(new observable("Ashot", 48));

            a.CollectionChanged += ObservableCollectionChanged;

            a.Add(new observable("Паула Хуан Непомукено Криспин Криспиано де ла Сантисима Тринидад Руиз Пикассо", 25));
            a.Add(new observable("Ян", 66));


        }


        static void ObservableCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {

                Console.WriteLine("Something added");
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {

                Console.WriteLine("Something removed");
            }
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {

                Console.WriteLine("Something replaced");
            }


        }

    }
}
