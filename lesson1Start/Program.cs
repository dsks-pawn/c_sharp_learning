using System;

namespace lesson1Start
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            // #region Console.Write();
            // Console.Write("Hello World!");
            // Console.WriteLine(10);
            // Console.Write(10.9f);
            // Console.Write(Environment.NewLine);
            // Console.Write(true);

            // Console.WriteLine(Console.ReadLine());
            // Console.ReadKey(true);
            // #endregion

            // #region Console.Write();
            // float c = 102.2f;
            // bool e = true;
            // long g = 222;
            // int? v = null;
            // string z = null;
            // char q = 'g';
            // const int l = 10;
            // byte bienByte = 3;
            // long bienLong = 9;
            // bienLong = bienByte;
            // #endregion

            // Console.WriteLine(5 / 2);
            // Console.WriteLine(6 * 3);
            // Console.WriteLine(6.3 * 3);
            // int tesz = 6;
            // tesz++;
            // Console.WriteLine(tesz);


            // #region Parse();

            // string stringConfirm = Console.ReadLine();
            // int numberNew = Int32.Parse(stringConfirm);
            // string result = numberNew % 2 == 0 ? "so chan" : "so le";
            // Console.WriteLine(result);

            // float tt = (float)5 / 2;
            // Console.WriteLine(tt);

            // float i = 55;
            // int b = (int)i;
            // Console.WriteLine(b);

            // string zx = "10";
            // int kq = int.Parse(zx);
            // Console.WriteLine(kq);

            // double e = double.Parse("10.9");
            // Console.WriteLine(e);

            // #endregion


            #region Parse();

            int Result;
            bool isSucccess;
            string Data1 = "10", Data2 = "Test";

            isSucccess = int.TryParse(Data1, out Result);
            Console.WriteLine(isSucccess == true ? "Success " : "Failed");
            Console.WriteLine(isSucccess);
            Console.WriteLine(Result);

            isSucccess = int.TryParse(Data2, out Result);
            Console.WriteLine(isSucccess == true ? "Success " : "Failed");
            Console.WriteLine(isSucccess);
            Console.WriteLine(Result);

            Console.WriteLine(Convert.ToInt64("999999999999"));
            #endregion
        }
    }
}
