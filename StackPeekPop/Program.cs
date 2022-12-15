using StackPeekPop;
using System;
namespace StackPeepPop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListPeekPop linkedListPeekPop = new LinkedListPeekPop();
            linkedListPeekPop.Push(70);
            linkedListPeekPop.Push(30);
            linkedListPeekPop.Push(56);
            linkedListPeekPop.Display();
            linkedListPeekPop.Peek();
            linkedListPeekPop.Pop();
            linkedListPeekPop.IsEmpty();
            
        }
    }
}
