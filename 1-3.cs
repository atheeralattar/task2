//Q1
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class SinglyLinkedList
{
    public Node head;

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }
    }

    public Node GetLastNode()
    {
        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList sll = new SinglyLinkedList();
        sll.AddNode(50);
        sll.AddNode(90);
        sll.AddNode(80);
        sll.AddNode(700);
        sll.Display();
    }
}


//Q2
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class SinglyLinkedList
{
    public Node head;

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }
    }

    public Node GetLastNode()
    {
        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void DisplayReverse(Node node)
    {
        if (node == null)
        {
            return;
        }
        DisplayReverse(node.next);
        Console.Write(node.data + " ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList sll = new SinglyLinkedList();
        sll.AddNode(20);
        sll.AddNode(40);
        sll.AddNode(60);
        sll.AddNode(80);
        sll.DisplayReverse(sll.head);
    }
}


//Q3
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class SinglyLinkedList
{
    public Node head;

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }
    }

    public Node GetLastNode()
    {
        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public int CountNodes()
    {
        int count = 0;
        Node current = head;

        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList sll = new SinglyLinkedList();
        sll.AddNode(10);
        sll.AddNode(20);
        sll.AddNode(30);
        sll.AddNode(40);
        sll.AddNode(100);

        Console.WriteLine("Number of nodes in the list: " + sll.CountNodes());
    }
}


