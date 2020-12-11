using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.BankClasses
{
    class Student
    {
        private string _name;
        private int _age;
        private int _id;

        public string Name => _name;
        public int Age => _age;
        public int Id => _id;

        public Student(string name)
        {
            _name = name;
        }
        public Student(string name, int age, int id)
        {
            _name = name;
            _age = age;
            _id = id;
        }
        public void SetAge(int newAge)
        {
            _age = newAge;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }
        public static void collect()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("ivan", 17, 1555));
            studentList.Add(new Student("idar", 18, 15));
            studentList.Add(new Student("lesuya", 27, 0));

            EditName(studentList, 1555, "lllllll");

            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
        }
        public static void EditName(List<Student>list, int searchId, string newName)
        {
            foreach (var item in list)
            {
                if(item.Id == searchId)
                {
                    item.SetName(newName);
                }
            }
        }
    }
}
