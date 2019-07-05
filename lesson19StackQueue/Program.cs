using System;
using System.Collections;

namespace lesson19Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Stack myStack2 = new Stack(5);
            ArrayList myArray = new ArrayList(5);
            Stack myStack3 = new Stack(myArray);

            Stack myStackTest = new Stack();
            myStackTest.Push("Edu");
            myStackTest.Push("Bqz");
            myStackTest.Push("Zaz");

            Console.WriteLine(myStackTest.Count);
            Console.WriteLine(myStackTest.Peek());
            Console.WriteLine(myStackTest.Count);
            Console.WriteLine(myStackTest.Pop());
            Console.WriteLine(myStackTest.Count);

            Console.WriteLine("---------------------------------");

            Queue myQueue = new Queue();
            Queue myQueue2 = new Queue(5);
            ArrayList myArrayQueue = new ArrayList(5);
            Queue myQueue3 = new Queue(myArrayQueue);

            Queue myQueueTest = new Queue();
            myQueueTest.Enqueue("Edu");
            myQueueTest.Enqueue("Bqz");
            myQueueTest.Enqueue("Zaz");

            Console.WriteLine(myQueueTest.Count);
            Console.WriteLine(myQueueTest.Peek());
            Console.WriteLine(myQueueTest.Count);
            Console.WriteLine(myQueueTest.Dequeue());
            Console.WriteLine(myQueueTest.Count);

        }
    }
}
