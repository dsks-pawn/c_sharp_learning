using System;
using System.Collections;

namespace lesson16ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArr = new ArrayList();
            ArrayList myArr2 = new ArrayList(5);
            ArrayList myArr3 = new ArrayList(myArr2);
            myArr2.Add("123456789");

            ArrayList arrPersons = new ArrayList();
            arrPersons.Add(new Person("Nguyen Van A", 18));
            arrPersons.Add(new Person("Nguyen Van B", 25));
            arrPersons.Add(new Person("Nguyen Van C", 20));


            Console.WriteLine("---------------------------- chua sort");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            arrPersons.Sort(new SortPerson());

            Console.WriteLine("---------------------------- da sort");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
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
            return "Name: " + name + " | " + "Age " + age;
        }
    }

    public class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p2 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
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
