using System;

namespace lesson12Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong meo ban dau {0}", Cat.count);

            Cat BlackCat = new Cat();
            Console.WriteLine("So luong meo hien tai {0}", Cat.count);
            Console.WriteLine("So luong meo den {0}", BlackCat.countOther);
            Cat WhiteCat = new Cat();
            Console.WriteLine("So luong meo hien tai {0}", Cat.count);
            Console.WriteLine("So luong meo trang {0}", WhiteCat.countOther);

            Console.WriteLine(Cat.LuyThua(3, 3));

            Console.WriteLine(TienIch.count);
            Console.WriteLine(TienIch.LuyThua(3, 3));

        }
    }

    class Cat
    {
        private int height;
        private int weight;
        public static int count = 0;
        public int countOther = 0;
        public Cat()
        {
            weight = 20;
            height = 500;
            count++;
            countOther++;
        }
        public static long LuyThua(int a, int b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
    }

    static class TienIch
    {
        public static int count = 0;

        static TienIch()
        {
            count = 99;
        }
        public static long LuyThua(int a, int b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
