using System;
using System.Collections;

namespace lesson20BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray arr1 = new BitArray(10);
            BitArray arr2 = new BitArray(10, true);

            bool[] arrBool = new bool[] { true, false, true, false, true };
            BitArray arr3 = new BitArray(arrBool);
            Console.Write("Array Bool value: ");
            PrintBit(arr3, 5);

            byte[] arrByte = new byte[] { 1, 2, 3, 4, 5 };
            BitArray arr4 = new BitArray(arrByte);
            Console.WriteLine("Array Byte length: {0} ", arr4.Length);
            Console.Write("Array Byte value: ");
            PrintBit(arr4, 8);


            int[] arrInt = new int[] { 1, 2, 3, 4, 5 };
            BitArray arr5 = new BitArray(arrInt);
            Console.Write("Array Int value: ");
            PrintBit(arr5, 32);

            BitArray A = new BitArray(new bool[] { false, false, true, true });
            BitArray B = new BitArray(new bool[] { false, true, false, true });
            Console.WriteLine("Initial values");
            Console.Write("A:");
            PrintBit(A, 4);
            Console.Write("B:");
            PrintBit(B, 4);
            Console.Write("Result AND: ");
            PrintBit(A.And(B), 4);




        }

        static void PrintBit(BitArray collection, int width)
        {
            int i = width;
            foreach (bool item in collection)
            {
                if (i < 1)
                {
                    i = width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode());
            }
            Console.WriteLine();
        }
    }
}
