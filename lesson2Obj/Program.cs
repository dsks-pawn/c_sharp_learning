using System;

namespace lesson2IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIXME:
            // boxing and unboxing
            int value = 109;
            object objectValue = value;
            int newValue = (int)objectValue;
            Console.Write(newValue);
            // FIXME:
            var testVar = "321";
            //FIXME:
            string stringAddDynamic = "Test";
            dynamic stringValue = stringAddDynamic;

            //FIXME:
            // object obj = "DeoHieuKieuGi";
            // Console.WriteLine(obj.Equals);
            // Console.WriteLine(obj.GetHashCode);
            // Console.WriteLine(obj.GetType);
            // Console.WriteLine(obj.ToString);
        }
    }
}
