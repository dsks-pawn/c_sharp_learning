using System;

namespace lesson15Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpeak animal = new Animal();
            ISpeak vegetal = new Vegetal();
            animal.Speak();
            vegetal.Speak();
        }
    }

    interface ISpeak
    {
         void Speak();
    }

    class Animal : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Animal speak");
        }
    }

    class Vegetal : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Vegetal speak");
        }
    }
}
