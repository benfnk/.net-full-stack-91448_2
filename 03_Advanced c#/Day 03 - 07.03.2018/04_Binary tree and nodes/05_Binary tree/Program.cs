﻿using System;

namespace BinaryTree
{
    class BinaryTreeNode
    {
        public char id;
        public BinaryTreeNode left; public BinaryTreeNode right;
        public BinaryTreeNode() {
            left = right = null;
        }
        public BinaryTreeNode(char _id) {
            id = _id;
            left = right = null;
        }
    }
    class BinaryTree
    {
        private BinaryTreeNode root;
        public BinaryTree() {
            root = null;
        }

        public void insert(char c)
        {
            addNode(c, ref root);
        }

        private void addNode(char c, ref BinaryTreeNode rptr)
        {
            if (rptr == null)
                rptr = new BinaryTreeNode(c);
            else if (rptr.left == null)
                addNode(c, ref rptr.left);
            else if (rptr.right == null)
                addNode(c, ref rptr.right);
            else
                addNode(c, ref rptr.left);
        }

        public void inOrderTraversal()
        {
            inOrderTraversalHelper(root);
        }
        private void inOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                inOrderTraversalHelper(r.left);
                Console.Write("{0}   ", r.id);
                inOrderTraversalHelper(r.right);
            }
        }
        public void preOrderTraversal()
        {
            preOrderTraversalHelper(root);
        }
        private void preOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                Console.Write("{0}   ", r.id);
                preOrderTraversalHelper(r.left);
                preOrderTraversalHelper(r.right);
            }
        }
        public void postOrderTraversal()
        {
            postOrderTraversalHelper(root);
        }
        private void postOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                postOrderTraversalHelper(r.left);
                postOrderTraversalHelper(r.right);
                Console.Write("{0}   ", r.id);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();
            b.insert('A');
            b.insert('B');
            b.insert('C');
            b.insert('D');
            b.insert('E');
            b.insert('G');
            b.insert('H');
            b.insert('F');
            b.insert('J');
            b.insert('K');
            b.insert('L');
            Console.WriteLine("The Inorder Traversal:\n");
            b.inOrderTraversal();
            Console.WriteLine("\n\nThe Preorder Traversal:\n");
            b.preOrderTraversal();
            Console.WriteLine("\n\nThe Postorder Traversal:\n");
            b.postOrderTraversal();
            Console.WriteLine();

        }

    }
}
