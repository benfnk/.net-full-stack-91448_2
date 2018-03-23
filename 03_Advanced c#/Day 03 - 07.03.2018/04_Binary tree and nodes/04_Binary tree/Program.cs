using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node currentNode = null;
            Tree.Insert(ref currentNode, 10);
            Tree.Insert(ref currentNode, 20);
            Tree.Insert(ref currentNode, 15);
            Tree.Insert(ref currentNode, 0);
            Tree.Insert(ref currentNode, 5);

            Console.WriteLine("contains tests:");

            Console.WriteLine($"{Tree.Contains(currentNode, 10) == true} , 10 exists");
            Console.WriteLine($"{Tree.Contains(currentNode, 4) == false} , 4 does not exist");
            Console.WriteLine($"{Tree.Contains(currentNode, 20) == true} , 20 exists");
            Console.WriteLine($"{Tree.Contains(currentNode, 0) == true} , 0 exists");
            Console.WriteLine($"{Tree.Contains(currentNode, 100) == false} , 100 does not exist");

            Console.WriteLine("find min tests:");

            Console.WriteLine($"{Tree.FindMin(currentNode) == 0} , 0 is the minumim");

            Console.WriteLine("find max tests:");

            Console.WriteLine($"{Tree.FindMin(currentNode) == 20} , 20 is the maximum");

            Console.WriteLine("level-order traversal - can be used for printing the tree:");
            Tree.LevelOrder(currentNode);


            Console.WriteLine();
            Console.WriteLine("pre-order traversal");
            Tree.PreOrder(currentNode);


            Console.WriteLine();
            Console.WriteLine("in-order traversal - can be used for sorting the tree:");
            Tree.InOrder(currentNode);


            Console.WriteLine();
            Console.WriteLine("post-order traversal");
            Tree.PostOrder(currentNode);
        }

        
    }
}


public class Node
{
    public int Data;
    public Node Left;
    public Node Right;
}

public static class Tree
{

    private static Node CreateNode(int data)
    {
        Node root = new Node();
        root.Data = data;
        return root;
    }


    public static void Insert(ref Node root, int data)
    {
        if (root == null)
        {
            root = new Node();
            root.Data = data;
            Console.WriteLine(root.Data);
            return;
        }

        if (root.Data >= data)
        {
            if (root.Left == null)
            {
                root.Left = new Node();
                root.Left.Data = data;
                Console.WriteLine(root.Data);
            }
            else
            {
                Insert(ref root.Left, data);
            }
        }
        else
        {
            if (root.Right == null)
            {
                root.Right = new Node();
                root.Right.Data = data;
                Console.WriteLine(root.Data);
            }
            else
            {
                Insert(ref root.Right, data);
            }
        }
    }

    public static bool Contains(Node root, int data)
    {
        if (root == null) return false;

        if (root.Data == data) return true;

        if (root.Data >= data)
        {
            Console.WriteLine(root.Data);
            return Contains(root.Left, data);
        }
        else
        {
            Console.WriteLine(root.Data);
            return Contains(root.Right, data);
        }
    }

    public static int FindMin(Node root)
    {
        if (root == null) return -1; //tree is empty

        if (root.Left == null) return root.Data; //this is the minumum

        return FindMin(root.Left);
    }


    public static int FindMax(Node root)
    {
        if (root == null) return -1; //tree is empty

        if (root.Right == null) return root.Data; //this is the minumum

        return FindMin(root.Right);
    }

    public static void LevelOrder(Node root)
    {
        if (root == null)
        {
            Console.WriteLine("Tree is empty.");
            return;
        }

        Queue<Node> printQ = new Queue<Node>();

        printQ.Enqueue(root);

        while (printQ.Count > 0)
        {
            Node current = printQ.Dequeue();

            Console.Write("{0} ", current.Data);

            if (current.Left != null) printQ.Enqueue(current.Left);

            if (current.Right != null) printQ.Enqueue(current.Right);
        }

        Console.WriteLine();
    }

    public static void PreOrder(Node root)
    {
        if (root == null)
        {
            Console.WriteLine();
            return;
        }

        Console.Write("{0} ", root.Data);

        if (root.Left != null) PreOrder(root.Left);

        if (root.Right != null) PreOrder(root.Right);
    }


    public static void InOrder(Node root)
    {
        if (root == null)
        {
            Console.WriteLine();
            return;
        }

        if (root.Left != null) InOrder(root.Left);

        Console.Write("{0} ", root.Data);

        if (root.Right != null) InOrder(root.Right);
    }


    public static void PostOrder(Node root)
    {
        if (root == null)
        {
            Console.WriteLine();
            return;
        }

        if (root.Right != null) PostOrder(root.Right);

        Console.Write("{0} ", root.Data);

        if (root.Left != null) PostOrder(root.Left);
    }
}
