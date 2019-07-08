using System;
using System.Collections.Generic;

namespace lesson22List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            List<int> myList2 = new List<int>(5);
            List<int> myList3 = new List<int>(myList2);

            List<int> arrPersons = new List<int>();
            arrPersons.Add(18);
            arrPersons.Add(25);
            arrPersons.Add(20);
            arrPersons.Insert(0, 99);

            foreach (int item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            Dictionary<string, string> myDic = new Dictionary<string, string>();
            Dictionary<string, string> myDic2 = new Dictionary<string, string>(5);
            Dictionary<string, string> myDic3 = new Dictionary<string, string>(myDic2);

            Dictionary<string, string> arrDic = new Dictionary<string, string>();
            arrDic.Add("f", "321");
            arrDic.Add("g", "123");
            arrDic.Add("z", "567");

            foreach (KeyValuePair<string, string> item in arrDic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
