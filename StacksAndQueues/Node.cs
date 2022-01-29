using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Node
    {
        //variables
        public int data;
        public Node next;
        /// <summary>
        /// Using constructor to initialized the data
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
