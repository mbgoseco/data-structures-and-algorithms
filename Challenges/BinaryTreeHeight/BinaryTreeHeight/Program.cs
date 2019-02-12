using System;
using HappyTrees.Classes;

namespace BinaryTreeHeight
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
            Console.WriteLine($"Height of binary tree is: {CalculateBinaryTreeHeight(node)}");
            Console.WriteLine($"Number of levels: {CalculateBinaryTreeLevels(node)}");
        }

        /// <summary>
        /// Measures the height of a binary tree.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Int value tree height</returns>
        public static int CalculateBinaryTreeHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null && root.Right == null)
            {
                return 0;
            }
            else if (root.Left == null)
            {
                return 1 + CalculateBinaryTreeHeight(root.Right);
            }
            else if (root.Right == null)
            {
                return 1 + CalculateBinaryTreeHeight(root.Left);
            }
            else
            {
                return 1 + Math.Max(CalculateBinaryTreeHeight(root.Left), CalculateBinaryTreeHeight(root.Right));
            }
        }

        /// <summary>
        /// Measures the number of levels in a binary tree.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Int value of max tree levels</returns>
        public static int CalculateBinaryTreeLevels(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null && root.Right == null)
            {
                return 1;
            }
            else if (root.Left == null)
            {
                return 1 + CalculateBinaryTreeLevels(root.Right);
            }
            else if (root.Right == null)
            {
                return 1 + CalculateBinaryTreeLevels(root.Left);
            }
            else
            {
                return 1 + Math.Max(CalculateBinaryTreeLevels(root.Left), CalculateBinaryTreeLevels(root.Right));
            }
        }
    }
}
