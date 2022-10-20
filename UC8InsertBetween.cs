using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    internal class UC8InsertBetween
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

        internal void InsertBetween(int previous, int data)
        {
            Node node = head;
            Node newnode = new Node(data);
            while (node.data != previous)
            {
                node = node.next;
            }
            newnode.next = node.next;
            node.next = newnode;
            Console.WriteLine("{0} inserted afer the {1} node in the linked list", newnode.data, node.data);
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
