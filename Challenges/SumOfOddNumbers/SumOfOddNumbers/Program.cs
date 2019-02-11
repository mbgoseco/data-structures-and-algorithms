using System;
using System.Collections.Generic;
using HappyTrees.Classes;

namespace SumOfOddNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(5);
            node.Left = new Node(0);
            node.Right = new Node(8);
            node.Left.Left = new Node(7);
            node.Left.Right = new Node(10);
            node.Right.Right = new Node(13);
            node.Left.Left.Right = new Node(2);
            node.Right.Right.Left = new Node(1);

            Console.WriteLine("              5             ");
            Console.WriteLine("             / \\           ");
            Console.WriteLine("            0   8           ");
            Console.WriteLine("           / \\   \\        ");
            Console.WriteLine("          7   10  13        ");
            Console.WriteLine("           \\     /         ");
            Console.WriteLine("           2    1           ");
            Console.WriteLine("                            ");
            Console.Write("Sum of odd nodes is: ");
            Console.WriteLine(SumOfOddNodes(node));
        }

        /// <summary>
        /// Takes in a binary tree and traverses it breadth first. While traversing, it checks if the current node odd and if so adds it to a sum total which is returned after the tree is fully traversed.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Sum of all odd nodes</returns>
        public static int SumOfOddNodes(Node root)
        {
            int sum = 0;
            Queue<Node> tree = new Queue<Node>();
            tree.Enqueue(root);

            while (tree.Count > 0)
            {
                Node front = tree.Dequeue();
                if ((int)front.Value % 2 != 0)
                {
                    sum += (int)front.Value;
                }

                if (front.Left != null)
                {
                    tree.Enqueue(front.Left);
                }
                if (front.Right != null)
                {
                    tree.Enqueue(front.Right);
                }
            }

            return sum;
        }
    }
}
