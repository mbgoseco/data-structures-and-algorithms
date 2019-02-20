using System;
using System.Collections.Generic;
using HappyTrees.Classes;
using HashTables.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Node(12);
            treeOne.Root.Left = new Node(0);
            treeOne.Root.Right = new Node(5);
            treeOne.Root.Left.Left = new Node(13);
            treeOne.Root.Left.Right = new Node(-4);
            treeOne.Root.Right.Right = new Node(3);
            treeOne.Root.Right.Right.Left = new Node(25);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Node(7);
            treeTwo.Root.Left = new Node(40);
            treeTwo.Root.Right = new Node(13);   // Intersect
            treeTwo.Root.Left.Left = new Node(22);
            treeTwo.Root.Left.Right = new Node(-10); 
            treeTwo.Root.Right.Right = new Node(3);  // Intersect
            treeTwo.Root.Left.Right.Left = new Node(-4); // Intersect
            treeTwo.Root.Right.Right.Left = new Node(111);
            treeTwo.Root.Right.Right.Right = new Node(25);   // Intersect

            Console.WriteLine("Intersecting values of both trees are:");

            var result = TreeIntersection(treeOne, treeTwo);

            foreach (var i in result)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Takes in two binary trees and returns a list of any node values that exist in both trees
        /// </summary>
        /// <param name="rootOne">Root node of first binary tree</param>
        /// <param name="rootTwo">Root node of second binary tree</param>
        /// <returns>List of intersecting node values</returns>
        public static object[] TreeIntersection(BinaryTree rootOne, BinaryTree rootTwo)
        {
            if (rootOne.Root == null || rootTwo.Root == null)
            {
                return null;
            }

            List<object> intersectValues = new List<object>();
            HashTable table = new HashTable();

            Queue<Node> TreeQueueOne = new Queue<Node>();
            TreeQueueOne.Enqueue(rootOne.Root);

            while (TreeQueueOne.Count > 0)
            {
                Node front = TreeQueueOne.Dequeue();
                table.Add(front.Value, front.Value);

                if (front.Left != null)
                {
                    TreeQueueOne.Enqueue(front.Left);
                }
                if (front.Right != null)
                {
                    TreeQueueOne.Enqueue(front.Right);
                }
            }

            Queue<Node> TreeQueueTwo = new Queue<Node>();
            TreeQueueTwo.Enqueue(rootTwo.Root);

            while (TreeQueueTwo.Count > 0)
            {
                Node front = TreeQueueTwo.Dequeue();
                
                if (table.Contains(front.Value))
                {
                    intersectValues.Add(front.Value);
                }

                if (front.Left != null)
                {
                    TreeQueueTwo.Enqueue(front.Left);
                }
                if (front.Right != null)
                {
                    TreeQueueTwo.Enqueue(front.Right);
                }
            }

            return intersectValues.ToArray();
        }
    }
}
