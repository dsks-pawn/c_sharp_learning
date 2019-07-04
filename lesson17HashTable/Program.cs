using System;
using System.Collections;

namespace lesson17HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHash = new Hashtable();
            Hashtable myHash2 = new Hashtable(5);
            myHash.Add("K", "Kteam");
            myHash.Add("Fe", "Free Education");
            Hashtable myHash3 = new Hashtable(myHash2);


            Console.WriteLine(myHash["K"]);
            Console.WriteLine(myHash.Count);
            foreach (DictionaryEntry item in myHash)
            {

                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
