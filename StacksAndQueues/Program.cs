using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
              Console.WriteLine("Welcome to Stack and Queue program using Linked List");
              StackandQueue();
              Console.ReadLine();
            }
        }
        //Method to Call the stack queue 
        public static void StackandQueue()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Please choose your option\n");
                Console.WriteLine("1.Stack 2.Queue 0.Exit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("\nCreating a Stack\n");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        Console.WriteLine("\nPeekOperationInStack\n");
                        linkedListStack.Peek();
                        linkedListStack.Display();
                        Console.WriteLine("\nPopOperation\n");
                        linkedListStack.Pop();
                        linkedListStack.Display();
                        Console.WriteLine("\nPopTillStackBecomesEmpty\n");
                        linkedListStack.StackIsEmpty();
                        linkedListStack.Display();
                        break;
                    case 2:
                        Console.WriteLine("\nCreating a Queue\n");
                        linkedListQueue.Enqueue(56);
                        linkedListQueue.Enqueue(30);
                        linkedListQueue.Enqueue(70);
                        linkedListQueue.Display();
                        Console.WriteLine("\nDequeue from Queue\n");
                        linkedListQueue.Dequeue();
                        linkedListQueue.Display();
                        Console.WriteLine("\nCopy element from Queue into Stack\n");
                        linkedListQueue.CopyElementIntoStack();
                        break;
                    case 0:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Check your option");
                        break;
                }
            }
        }
    }
}
            
