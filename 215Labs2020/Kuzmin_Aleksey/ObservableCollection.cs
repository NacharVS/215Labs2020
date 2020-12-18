using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Student
    {
        string _name;
        int _age;
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string Name => _name;
        public int Age => _age;
        public static void Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Что то ввели!");
            }
            else if(e.Action==NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Что то удалили!");
            }           
            else if (e.Action==NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Что то изменили!");
            }
        }
        public static void Program()
        {
            ObservableCollection<Student> student = new ObservableCollection<Student>();
            
            student.CollectionChanged += Changed;
            student.Add(new Student("Рифат", 18));
            student.Add(new Student("Расиф", 18));
            student[0]._name = "Рузаль";
            foreach (var item in student)
            {
                Console.WriteLine( item._name);
            }
        }
    }
}
