using System;

namespace lesson14Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Speak();
            dog.Speak();
        }
    }
    abstract class Animal
    {
        public abstract void Speak();

    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }
}
