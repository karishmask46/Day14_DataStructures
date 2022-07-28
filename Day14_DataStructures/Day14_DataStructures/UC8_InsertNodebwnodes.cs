using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_DataStructures
{
    internal class UC7_SearchNode
    {
        internal Node head; //new 
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp  = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal Node InsertAtParticularPosition(int PreviousData, Node Newdata)
        {
            Node temp = this.head;
            while (temp != null)
            {
                while (temp.data == PreviousData)
                {
                    Node newnode = temp.next;
                    temp.next = Newdata;
                    temp.next.next = newnode;
                    break;
                }
                temp = temp.next;
            }
            return head;
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
