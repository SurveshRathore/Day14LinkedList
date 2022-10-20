using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    internal class UC9DeleteNode
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

        internal void DeleteNode(int data)
        {
            Node temp = head;
            Node newnode = new Node(data);
            while (temp.next.data != data)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
            
            //Console.WriteLine("{0} inserted afer the {1} node in the linked list", newnode.data, node.data);
        }
        public void Size()
        {
            int llsize = 0;
            Node temp = head;
            while (temp != null)
            {
                llsize++;
                temp = temp.next;
            }

            Console.WriteLine("The size of the linked list is: " + llsize);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Console.Write("The element of the linked list are: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }
    }
}
