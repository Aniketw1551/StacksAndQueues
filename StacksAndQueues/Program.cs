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
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nPlease choose your option");
                Console.WriteLine("1.Stack 0.Exit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Creating A Stack\n");
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
            
