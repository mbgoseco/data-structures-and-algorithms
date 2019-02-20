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
            Node node = new Node(12);
            node.Left = new Node(0);
            node.Right = new Node(5);
            node.Left.Left = new Node(13);
            node.Left.Right = new Node(-4);
            node.Right.Right = new Node(3);
            node.Right.Right.Left = new Node(25);

            Node nodeTwo = new Node(7);
            nodeTwo.Left = new Node(40);
            nodeTwo.Right = new Node(13);   // Intersect
            nodeTwo.Left.Left = new Node(22);
            nodeTwo.Left.Right = new Node(-10); 
            nodeTwo.Right.Right = new Node(3);  // Intersect
            nodeTwo.Left.Right.Left = new Node(-4); // Intersect
            nodeTwo.Right.Right.Left = new Node(111);
            nodeTwo.Right.Right.Right = new Node(25);   // Intersect

            Console.WriteLine("Intersecting values of both trees are:");

            var result = TreeIntersection(node, nodeTwo);

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
        public static object[] TreeIntersection(Node rootOne, Node rootTwo)
        {
            List<object> intersectValues = new List<object>();
            HashTable table = new HashTable();

            Queue<Node> TreeQueueOne = new Queue<Node>();
            TreeQueueOne.Enqueue(rootOne);

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
            TreeQueueTwo.Enqueue(rootTwo);

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
