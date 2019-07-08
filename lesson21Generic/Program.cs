using System;

namespace lesson21Generic
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            double c = 1.2, d = 5.6;
            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);

            MyGeneric<int> MyG = new MyGeneric<int>(5);
            MyG.SetItemValue(0, 10);
            Console.WriteLine(MyG.GetByIndex(7));
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    public class MyGeneric<T>
    {
        private T[] items;
        public T[] Item
        {
            get
            {
                return items;
            }
        }
        public MyGeneric(int Size)
        {
            items = new T[Size];
        }
        public T GetByIndex(int Index)
        {
            if (Index < 0 || Index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[Index];
            }
        }

        public T SetItemValue(int Index, T value)
        {
            if (Index < 0 || Index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[Index] = value;
            }
        }
    }
}
