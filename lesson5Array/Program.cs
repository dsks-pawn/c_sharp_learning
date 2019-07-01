using System;

namespace lesson5Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[10];
            int[] array2 = { 2, 64, 32 };
            foreach (var item in array2)
            {
                Console.WriteLine(item);
                Console.WriteLine(array2.GetLength(0));
            }

            int[,] array3 = new int[2, 3];

            string[,] array4 = new string[,]{
                {"Dô", "Cơ", "32"},
                {"Bích", "Tép", "43"}
            };

            foreach (var i in array4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    Console.Write("{0,5}", array4[i, j]);
                }
                Console.WriteLine();
            }


            int[,,] array3Chieu = {
                {
                    {1, 2},
                    {3,5}
                },
                {
                    {4,6},
                    {7,8}
                }
            };

            for (int i = 0; i < array3Chieu.GetLength(0); i++)
            {
                for (int j = 0; j < array3Chieu.GetLength(1); j++)
                {
                    for (int k = 0; k < array3Chieu.GetLength(2); k++)
                    {
                        Console.Write("{0,5}", array3Chieu[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            float[][] arrayZicZac = {
                 new float[] {1.2f, 3, 4.5f},
                 new float[] {1.2f, 3, 4.5f, 6.3f}
            };
            for (int i = 0; i < arrayZicZac.Length; i++)
            {
                for (int j = 0; j < arrayZicZac[i].Length; j++)
                {
                    Console.WriteLine(arrayZicZac[i][j]);
                }
                Console.WriteLine();
            }

            foreach (float[] item in arrayZicZac)
            {
                foreach (float i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            int[] array6 = { 1, 2, 5, 3 };
            Array.Reverse(array6);
            Console.WriteLine(Array.IndexOf(array6, 5));
        }
    }
}
