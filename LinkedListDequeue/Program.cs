using System;
namespace LinkedListDequeue
{
    internal class program
    {
        static void Main(string[] args)
        {
            LinkedDeQueue linkedDeQueue = new LinkedDeQueue();
            linkedDeQueue.Dequeue(70);
            linkedDeQueue.Dequeue(30);
            linkedDeQueue.Dequeue(50);
            linkedDeQueue.Display();
          
           

        }
    }
}
