using System;

namespace lesson8Enum
{
    class Program
    {
        enum Name
        {
            BLUE = 2,
            RED = 3,
            GREEN = 4
        }
        static void Main(string[] args)
        {
            Console.Write((int)Name.BLUE);
        }
    }
}
