using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    internal class UC7SearchNode
    {
        Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Search(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if(temp.data == data)
                {
                    Console.WriteLine("The node {0} is found.", temp.data);
                    return;
                }
                temp = temp.next;
            }
            if(temp == null)
            {
                Console.WriteLine("\nThe Node with value {0} is not in the linked list.", data);
            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }
    }
}
