using System;

namespace lesson13inheritance
{
    class Animal
    {
        protected double weight;
        protected double height;
        protected int legs;
        public Animal()
        {

        }

        public Animal(double w, double h, int l)
        {
            weight = w;
            height = h;
            legs = l;
        }

        public void Info()
        {
            Console.WriteLine("ANIMAL");
            Console.WriteLine("Weight: " + weight + " Height: " + height + " Legs: " + legs);
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            weight = 500;
            height = 50;
            legs = 2;
        }

        public Cat(double w, double h, int l) : base(w, h, l)
        {
            weight = w;
            height = h;
            legs = l;
            Console.WriteLine("--{0} {1} {2}", w, h, l);
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine("CAT");
            Console.WriteLine("Weight: " + weight + " Height: " + height + " Legs: " + legs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat(500, 50, 2);
            BlackCat.Info();

        }
    }
}
