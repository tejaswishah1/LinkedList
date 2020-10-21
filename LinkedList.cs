using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAssignment
{
    public class LinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;

            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void AddAtFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
        }
        public void Append(int data)
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

        }
        internal Node Insert(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + "\n");
                    temp = temp.next;
                }
            }
        }
    }
}
