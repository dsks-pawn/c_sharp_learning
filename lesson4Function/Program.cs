using System;


namespace lesson4Function
{
    class Program
    {
        static int firstNumber = 5;
        static int lastNumber = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("firstNumber: " + firstNumber);
            Console.WriteLine("lastNumber: " + lastNumber);
            IncreaseValue(ref firstNumber, out lastNumber);
            Console.WriteLine("firstNumber: " + firstNumber);
            Console.WriteLine("lastNumber: " + lastNumber);
            Console.ReadKey();
        }

        static int Test()
        {
            return firstNumber + lastNumber;
        }

        static void IncreaseValue(ref int value, out int value2)
        {
            value2 = 2;
            value++;
        }

    }
}
