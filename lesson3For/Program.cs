using System;

namespace lesson3For
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            int a = 2;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    goto case 1;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            // TODO:
                #region ví dụ 2
                int b = 2;
                if (b == 2)
                {
                    goto testGoto;
                }

                Console.WriteLine("B == 1");
            testGoto:
                Console.WriteLine("B == 2");

                #endregion

            // TODO:
                var count = 0;
            beginLoop:
                Console.WriteLine("for " + count);
                count++;
                if (count < 10) goto beginLoop;
                Console.WriteLine("End loop");
            //TODO:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for " + i);
            }
            //TODO:
            int l = 0;
            while (l < 10)
            {
                Console.WriteLine("while " + l);
                l++;
            }
            //TODO:
            int g = 0;
            do
            {
                Console.WriteLine("while " + g);
                g++;
            } while (g < 10);
        }
    }
}
