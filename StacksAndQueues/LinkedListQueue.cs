using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListQueue
    {
        //variable
        private Node front;
        //Method to Enqueue the specified value
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        //Method to display the elements of Queue
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue: " + temp.data);
                    temp = temp.next;
                }
            }
        }
        //Dequeues this instance
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Node temp = this.front;
            this.front = front.next;
            temp.next = null;
            Console.WriteLine("{0} Dequeued from Queue", temp.data);
        }
        //Method to Copy elements into stack
        public void CopyElementIntoStack()
        {
            int[] array = new int[6];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(20);
            queue.Enqueue(36);
            queue.Enqueue(50);
            queue.Enqueue(66);
            queue.CopyTo(array, 0);
            foreach (int item in array)
            {
                Console.WriteLine("Element in Array:{0}", item);
            }
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("\nCopy array element into stack\n");
            foreach (int element in array)
            {
                if (element != 0)
                    stack.Push(element);
            }
            foreach (int element in stack)
            {
                if (element != 0)
                    Console.WriteLine("Element in stack:{0}", element);
            }
        }
    }
}
