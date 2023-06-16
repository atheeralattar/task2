using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addNode(1);
            list.addNode(2);
            list.addNode(3);
            list.addNode(4);
            list.addNode(5);
            Node node = list.GetNode(4);
            if (node != null)
            {
                Console.WriteLine(node.data);
            }
            else
            {
                Console.WriteLine("Node not found.");
            }
            int index = list.FirstElement(3);
            if (index != -1)
            {
                Console.WriteLine("Found element at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
            if (list.IsEmpty() != null)
            {
                Console.WriteLine("List not  empty");
            }
            else
            {
                Console.WriteLine("List   empty");

            }

            Console.ReadLine();
        }
    }
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

    }
    class LinkedList
    {
        private Node head;
        public void addNode(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;


            }

        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public Node GetNode(int index)
        {
            if (index < 0 || head == null)
            {
                return null;
            }
            Node current = head;
            int i = 0;
            while (current != null && i < index)
            {
                current = current.next;
                i++;
            }

            return current;
        }
        public int FirstElement(int element)
        {
            if (head == null)
            {
                return -1;
            }
            Node current = head;
            int i = 0;
            while (current != null)
            {
                if (current.data == element)
                {
                    return i;
                }
                current = current.next;
                i++;

            }
            return -1;
        }
    }

}