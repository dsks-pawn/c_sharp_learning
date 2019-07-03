using System;

namespace lesson13inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat();
            BlackCat.Info();
        }
    }

    class Animal
    {
        protected double weight;
        protected double height;
        protected int legs;

        public void Info()
        {
            Console.WriteLine("Weight: " + weight + " Height: " + height + " Legs: " + legs);
        }

        public Animal()
        {

        }

        public Animal(double w, double h, int l)
        {
            weight = w;
            height = h;
            legs = l;
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
    }
}
