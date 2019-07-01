using System;
using System.Diagnostics;

namespace lesson6forSS
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[20000000];
            int result = 0;
            int[] intArray2 = new int[20000000];
            int result2 = 0;


            int Length = intArray.Length;
            Stopwatch start = new Stopwatch();
            start.Start();
            for (int i = 0; i < Length; i++)
            {
                result += intArray[i];
            }
            start.Stop();



            Stopwatch start2 = new Stopwatch();
            start2.Start();
            foreach (var item in intArray2)
            {
                result2 += item;
            }
            start2.Stop();
            Console.WriteLine("For: {0} giay {1} mili giay", start.Elapsed.Seconds, start.Elapsed.Milliseconds);
            Console.WriteLine("ForEach: {0} giay {1} mili giay", start2.Elapsed.Seconds, start2.Elapsed.Milliseconds);

        }
    }
}
