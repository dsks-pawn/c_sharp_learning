using System;

namespace lesson23Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTuple = Tuple.Create<int, string>(1, "HowAreYou");
            var myTuple2 = new Tuple<int, string, bool>(1, "HowAreYou", true);
            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple2.Item2);

            var now = getCurrentDayMonthYear();
            Console.WriteLine("Time: {0}/{1}/{2}", now.Item1, now.Item2, now.Item3);
            Console.WriteLine(now.ToString());
        }

        static Tuple<int, int, int> getCurrentDayMonthYear()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
    }
}