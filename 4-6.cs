//4.Write a c# program to insert a node at any position in a Singly Linked List.

using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Insert(int data, int index)
    {
        Node newNode = new Node(data);

        if (index == 1)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node temporary = head;
            for (int i = 1; i < position - 1 && temporary != null; i++)
            {
                temporary = temporary.Next;
            }
            
            newNode.Next = temporary.Next;
            temporary.Next = newNode;
        }
    }


    //5.Write a c# program to insert a node at the beginning of a Singly Linked List.
    public void InsertOnFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Head;
        Head = newNode;
    }


    //6. Write a  c# program to insert a node at the end of a Singly Linked List    
    public void InsertOnLast(int data)
    {
        Node firstNode = Head;
        while (firstNode.Next != null)
        {
            firstNode = firstNode.Next;
        }
        firstNode.Next = newNode;
    }



    public void OutputLinkedList()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();

        
        linkedList.Insert(254, 1); 
        linkedList.Insert(36, 2);
        linkedList.OutputLinkedList();
    }
}


