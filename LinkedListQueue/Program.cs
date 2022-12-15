using System;
namespace LinkedListQueue
{
    internal class program
    {
        static void Main(string[] args)
        {
            LinkedListEnqueue linkedListEnqueue = new LinkedListEnqueue();
            linkedListEnqueue.Enqueue(56);
            linkedListEnqueue.Enqueue(30);
            linkedListEnqueue.Enqueue(70);
            linkedListEnqueue.Display();

        }
    }
}
