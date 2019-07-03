using System;

namespace lesson10Class
{
    class Animal
    {
        public double Weight;
        public double Height;

        public void Info()
        {
            Console.WriteLine("Class Animal --- Weight: {0}, Height: {1}", Weight, Height);
            return;
        }
    }

    class Test
    {
        public double Weight;
        public double Height;

        public Test()
        {
            Weight = 200;
            Height = 200;
        }
        public Test(int w, int h)
        {
            Weight = w;
            Height = h;
        }
        public void Info()
        {
            Console.WriteLine("Class Test --- Weight: {0}, Height: {1}", Weight, Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Weight = 2;
            Dog.Height = 50;

            Animal Cat = new Animal();
            Cat.Weight = 1;
            Cat.Height = 30;

            Dog.Info();
            Cat.Info();

            Test Test = new Test(3, 3);
            Test.Info();
        }
    }
}
