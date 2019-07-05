using System;
using System.Collections;

namespace lesson18SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList arr1 = new SortedList(new SortPerson());
            SortedList arr2 = new SortedList(5);
            arr1.Add(new Person("vvvv", 40), 10);
            arr1.Add(new Person("ZZZ", 20), 10);
            arr1.Add(new Person("BBB", 30), 2);

            foreach (DictionaryEntry item in arr1)
            {
                Console.WriteLine("Key: {0} + Value: {1}", item.Key, item.Value);
            }
        }
    }

    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }

        public override string ToString()
        {
            return name + "-" + age;
        }
    }
    public class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person a = x as Person;
            Person b = y as Person;
            if (b == null || b == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (a.Age < b.Age)
                {
                    return 1;
                }
                else if (a.Age == b.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
