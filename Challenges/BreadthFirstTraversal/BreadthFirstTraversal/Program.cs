using System;
using HappyTrees.Classes;
using System.Collections.Generic;

namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            Console.WriteLine("              5             ");
            Console.WriteLine("             / \\           ");
            Console.WriteLine("            2   4           ");
            Console.WriteLine("           / \\   \\        ");
            Console.WriteLine("          6   11  9         ");
            Console.WriteLine("           \\     /         ");
            Console.WriteLine("           7    1           ");
            Console.WriteLine("                            ");
            Console.WriteLine("Breadth first order is:");
            BreadthFirst(node);
            Console.WriteLine();
        }

        public static object[] BreadthFirst(Node root)
        {
            List<object> breadthList = new List<object>();
            Queue<Node> TreeQueue = new Queue<Node>();
            TreeQueue.Enqueue(root);

            while (TreeQueue.Count > 0)
            {
                Node front = TreeQueue.Dequeue();
                breadthList.Add(front.Value);
                Console.Write($" {front.Value} ");

                if (front.Left != null)
                {
                    TreeQueue.Enqueue(front.Left);
                }
                if (front.Right != null)
                {
                    TreeQueue.Enqueue(front.Right);
                }
            }

            return breadthList.ToArray();
        }
    }


}
